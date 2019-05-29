using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using ReadWriteExcel.DbNModels;
using ReadWriteExcel.Models;

namespace ReadWriteExcel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImportExcelController : ControllerBase
    {
        protected ELAVONTESTContext context_ = new ELAVONTESTContext();

        [HttpPost("transacciones")]
        public async Task<ActionResult> OnPostImportTransactions(IFormFile formFile, [FromForm] int IdUsuario, CancellationToken cancellationToken)
        {
            String mn = DateTime.Now.Month.ToString();
            String yy = DateTime.Now.Year.ToString();

            BdCargasMasivas carga = new BdCargasMasivas()
            {
                DescAttach = "Carga de Transacciones",
                IdArchivoAttach = 2,
                FechaCarga = DateTime.Now,
                IdUsuarioAlta = IdUsuario,
                Status = "Pendiente"
            };

            context_.BdCargasMasivas.Add(carga);
            await context_.SaveChangesAsync();

            int idcarga = carga.IdCargaMasiva;

            if (formFile == null || formFile.Length <= 0)
            {
                return BadRequest("FormFile esta vacio");
            }
            if (!Path.GetExtension(formFile.FileName).Equals(".xlsx", StringComparison.OrdinalIgnoreCase))
            {
                return BadRequest("No es compatible con la extension del archivo");
            }

            var list = new List<BdTransaccionesPaso>();

            using (var stream = new MemoryStream())
            {
                await formFile.CopyToAsync(stream, cancellationToken);

                using (var package = new ExcelPackage(stream))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    var rowCount = worksheet.Dimension.Rows;

                    for (int row = 2; row <= rowCount; row++)
                    {
                        BdTransaccionesPaso paso = new BdTransaccionesPaso()
                        {
                            IdCarga = idcarga,
                            Month = Convert.ToInt32(mn),
                            Year = Convert.ToInt32(yy),
                            NoAfiliacion = Convert.ToInt32(worksheet.Cells[row, 1].Value.ToString().Trim()),
                            ApprovedcCount = Convert.ToInt32(worksheet.Cells[row, 2].Value.ToString().Trim()),
                            Declinedcount = Convert.ToInt32(worksheet.Cells[row, 3].Value.ToString().Trim())
                        };
                        list.Add(paso);
                    }
                    await context_.BdTransaccionesPaso.AddRangeAsync(list);
                    context_.SaveChanges();
                }
            }

            await context_.Database.ExecuteSqlCommandAsync("EXEC SP_PROCESAR_CARGA_TRANSACCIONES @ID_CARGA",
                new SqlParameter("@ID_CARGA", idcarga));

            return Ok(idcarga.ToString());
        }

        [HttpPost("Bloqueos")]
        public async Task<ActionResult> OnPostImportLocks(IFormFile formFile, [FromForm] int IdUsuario, CancellationToken cancellationToken)
        {

            String mn = DateTime.Now.Month.ToString();
            String yy = DateTime.Now.Year.ToString();

            BdCargasMasivas carga = new BdCargasMasivas()
            {
                DescAttach = "Carga de Bloqueos",
                IdArchivoAttach = 2,
                FechaCarga = DateTime.Now,
                IdUsuarioAlta = IdUsuario,
                Status = "Pendiente"
            };

            context_.BdCargasMasivas.Add(carga);
            await context_.SaveChangesAsync();

            int idcarga = carga.IdCargaMasiva;

            if (formFile == null || formFile.Length <= 0)
            {
                return BadRequest("FormFile esta vacio");
            }
            if (!Path.GetExtension(formFile.FileName).Equals(".xlsx", StringComparison.OrdinalIgnoreCase))
            {
                return BadRequest("No es compatible con la extension del archivo");
            }

            var list = new List<BdBloqueosPaso>();

            using (var stream = new MemoryStream())
            {
                await formFile.CopyToAsync(stream, cancellationToken);

                using (var package = new ExcelPackage(stream))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    var rowCount = worksheet.Dimension.Rows;

                    for (int row = 2; row <= rowCount; row++)
                    {
                        var bloqueo = 0;
                        var celda = worksheet.Cells[row, 6].Value == null ? "No" : worksheet.Cells[row, 6].Value.ToString().Trim();
                        if (celda == "Si" || celda == "Sí")
                        {
                            bloqueo = 1;
                        }

                        BdBloqueosPaso paso = new BdBloqueosPaso()
                        {
                            IdCarga = idcarga,
                            Month = Convert.ToInt32(mn),
                            Year = Convert.ToInt32(yy),
                            NoAfiliacion = worksheet.Cells[row, 1].Value.ToString().Trim(),
                            Cp = worksheet.Cells[row, 2].Value.ToString().Trim(),
                            Proveedor = worksheet.Cells[row, 3].Value.ToString().Trim(),
                            Territorio = worksheet.Cells[row, 4].Value.ToString().Trim(),
                            TotalRollos = Convert.ToInt32(worksheet.Cells[row, 5].Value.ToString().Trim()),
                            Bloqueo = bloqueo,
                            Mensaje = worksheet.Cells[row, 7].Value == null ? null : worksheet.Cells[row, 7].Value.ToString().Trim()
                        };

                        list.Add(paso);
                    }
                    await context_.BdBloqueosPaso.AddRangeAsync(list);
                    context_.SaveChanges();
                }
            }

            await context_.Database.ExecuteSqlCommandAsync("EXEC SP_PROCESAR_CARGA_BLOQUEOS @ID_CARGA",
                new SqlParameter("@ID_CARGA", idcarga));

            return Ok(idcarga.ToString());
        }
    }
}