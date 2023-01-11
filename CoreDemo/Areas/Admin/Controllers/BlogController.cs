using ClosedXML.Excel;
using CoreDemo.Areas.Admin.Models;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        public IActionResult ExportStaticExcelBlogList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("blog listesi");
                worksheet.Cell(1, 1).Value = "Blog Başlık";
                worksheet.Cell(1, 2).Value = "Eklenme Tarih";

                int blogRowCount = 2;
                foreach (var item in GetBlogList())
                {
                    worksheet.Cell(blogRowCount, 1).Value = item.BlogName;
                    worksheet.Cell(blogRowCount, 2).Value = item.BlogDate;
                    blogRowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Dokuman1.xlsx");
                }
            }
        }
        public IActionResult BlogListWithExcel()
        {
            return View();
        }
        public List<BlogModel> GetBlogList()
        {
            List<BlogModel> bm = new List<BlogModel>
            {
                new BlogModel{BlogName="C# Programlama", BlogDate="01.02.2023"},
                new BlogModel{BlogName="Python Programlama", BlogDate="02.02.2023"},
                new BlogModel{BlogName="VueJs Programlama", BlogDate="03.01.2023"},
                new BlogModel{BlogName="NuxtJs Programlama", BlogDate="04.02.2023"},
            };
            return bm;
        }
        public IActionResult ExportDynamicExcelBlogList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("blog listesi");
                worksheet.Cell(1, 1).Value = "Blog Başlık";
                worksheet.Cell(1, 2).Value = "Eklenme Tarih";

                int blogRowCount = 2;
                foreach (var item in BlogTitleList())
                {
                    worksheet.Cell(blogRowCount, 1).Value = item.BlogName;
                    worksheet.Cell(blogRowCount, 2).Value = item.BlogDate;
                    blogRowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Dokuman2.xlsx");
                }
            }
        }
        public List<BlogModel2> BlogTitleList()
        {
            List<BlogModel2> blogModel = new List<BlogModel2>();
            using (var c = new Context())
            {
                blogModel = c.Blogs.Select(x => new BlogModel2
                {
                    BlogName = x.BlogTitle,
                    BlogDate = x.BLogCreateDate.ToString("dd.MM.yyyy")
                }).ToList();
            }
            return blogModel;
        }
        public IActionResult BlogTitleListWithExcel()
        {
            return View();
        }

    }
}
