using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BachHoaXanh02.Models;

namespace BachHoaXanh02.Controllers
{
    public class HomeController : Controller
    {
        // Action Index để hiển thị danh sách sản phẩm và banner
        public ActionResult Index()
        {
            // Dữ liệu sản phẩm nổi bật
            List<Product> featuredProducts = new List<Product>
            {
                new Product { Id = 1, Name = "Nước tẩy trang Garnier sạch nhờn 400ml", ImageUrl = "https://cdn.tgdd.vn/Products/Images/3708/305808/bhx/nuoc-tay-trang-garnier-salicylic-bha-lam-sach-sau-sach-nhon-chai-400ml-202407230933002090.jpg", Description = "Nước tẩy trang hiệu quả cho làn da sạch nhờn", Price = 150000 },
                new Product { Id = 2, Name = "Gà dai nhập khẩu Hàn Quốc 1.3kg-1.4kg", ImageUrl = "https://cdnv2.tgdd.vn/bhx-static/bhx/Products/Images/8790/316943/bhx/323328-min_202409251435161115.jpg", Description = "Thịt gà nhập khẩu tươi ngon", Price = 79000 },
                new Product { Id = 3, Name = "2 bàn chải Colgate SlimSoft Flex Clean", ImageUrl = "https://cdn.tgdd.vn/Products/Images/2491/228857/bhx/bo-2-ban-chai-danh-rang-colgate-flex-clean-202402201612311487.jpg", Description = "Bàn chải Colgate làm sạch sâu", Price = 70000 },
                new Product { Id = 4, Name = "Ba rọi heo nhập khẩu 500g", ImageUrl = "https://cdnv2.tgdd.vn/bhx-static/bhx/Products/Images/8781/275806/bhx/325486-min-1_202409091605199273.jpg", Description = "Ba rọi heo nhập khẩu chất lượng cao", Price = 63000 },
                new Product { Id = 5, Name = "Thùng 30 gói mì 3 Miền tôm hùm 65g", ImageUrl = "https://cdn.tgdd.vn/Products/Images/2565/175933/bhx/thung-30-goi-mi-3-mien-tom-hum-65g-202306160838587082.jpg", Description = "Mì 3 Miền tôm hùm thơm ngon", Price = 69000 },
                new Product { Id = 6, Name = "Rau muống hạt 400g", ImageUrl = "https://cdn.tgdd.vn/Products/Images/8820/226916/bhx/rau-muong-hat-400g-202407180929365897.jpg", Description = "Rau muống tươi ngon 400g", Price = 5000 },
                new Product { Id = 7, Name = "Cải bẹ xanh 400g", ImageUrl = "https://cdn.tgdd.vn/Products/Images/8820/318099/bhx/cai-be-xanh-400g-202408021341394360.jpg", Description = "Cải bẹ xanh tươi ngon 400g", Price = 5000 },
                new Product { Id = 8, Name = "Rau dền 400g", ImageUrl = "https://cdn.tgdd.vn/Products/Images/8820/222855/bhx/rau-den-400g-202408021341579064.jpg", Description = "Rau dền tươi ngon 400g", Price = 5000 }
            };

            // Dữ liệu sản phẩm flash sale
            List<Product> flashSaleProducts = new List<Product>
            {
                new Product { Id = 9, Name = "Dầu đậu nành Meizan 5 lít", ImageUrl = "https://cdn.tgdd.vn/Products/Images/2286/310854/bhx/dau-dau-nanh-meizan-can-5-lit-202308020919216732.jpg", Description = "Dầu đậu nành chất lượng cao", Price = 239000 },
                new Product { Id = 10, Name = "Trà sữa trân châu Hillway hộp 260g", ImageUrl = "https://cdn.tgdd.vn/Products/Images/2385/320951/bhx/tra-sua-tran-chau-hillway-hop-416g-clone-202401031430147436.jpg", Description = "Trà sữa vị trân châu hấp dẫn", Price = 40000 },
                new Product { Id = 11, Name = "Sữa tắm Lifebuoy matcha & khổ qua 784ml", ImageUrl = "https://cdnv2.tgdd.vn/bhx-static/bhx/Products/Images/2444/195634/bhx/195634-2-1_202410011644409366.jpg", Description = "Sữa tắm diệt khuẩn bảo vệ cơ thể", Price = 180000 },
                new Product { Id = 12, Name = "Hạt nêm thịt thăn Knorr 400g", ImageUrl = "https://cdnv2.tgdd.vn/bhx-static/bhx/Products/Images/2806/82271/bhx/82271-thumb-omni_202409271110139607.jpg", Description = "Hạt nêm Knorr chất lượng cao", Price = 32000 },
                new Product { Id = 13, Name = "Gạo thơm Vua Gạo ST25 túi 5kg", ImageUrl = "https://cdn.tgdd.vn/Products/Images/2513/236014/bhx/gao-thom-vua-gao-st25-tui-5kg-202312071149419082.jpg", Description = "Gạo thơm Vua Gạo ST25", Price = 145000 },
                new Product { Id = 14, Name = "Gạo thơm Neptune ST25 Extra túi 5kg", ImageUrl = "https://cdnv2.tgdd.vn/bhx-static/bhx/Products/Images/2513/324448/bhx/thiet-ke-chua-co-ten-2024-09-17t161742457_202409171617500408.jpg", Description = "Gạo thơm Neptune ST25 Extra", Price = 145000 },
                new Product { Id = 15, Name = "Sữa tắm nước hoa Lux hoa hồng Pháp 562ml", ImageUrl = "https://cdnv2.tgdd.vn/bhx-static/bhx/Products/Images/2444/253027/bhx/253027-5-1_202410011643081209.jpg", Description = "Sữa tắm nước hoa Lux", Price = 139000 }
            };

            // Dữ liệu banner
            List<Banner> banners = new List<Banner>
            {
                new Banner { Id = 1, ImageUrl = "https://cdnv2.tgdd.vn/bhx-static/bhx/5599/trang-cate-pc_202409211120577044.jpg", AltText = "Banner 1" },
                new Banner { Id = 2, ImageUrl = "https://cdnv2.tgdd.vn/bhx-static/bhx/5599/980x125-2_202409131342015375.png", AltText = "Banner 2" },
                new Banner { Id = 3, ImageUrl = "https://cdnv2.tgdd.vn/bhx-static/bhx/5599/pc_202410011153052300.png", AltText = "Banner 3" }
            };

            // Gán dữ liệu vào ViewModel
            HomeViewModel model = new HomeViewModel
            {
                FeaturedProducts = featuredProducts,
                FlashSaleProducts = flashSaleProducts,
                Banners = banners
            };

            return View(model);
        }

        // Action Details để hiển thị chi tiết sản phẩm
        public ActionResult Details(int id)
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Nước tẩy trang Garnier sạch nhờn 400ml", ImageUrl = "https://cdn.tgdd.vn/Products/Images/3708/305808/bhx/nuoc-tay-trang-garnier-salicylic-bha-lam-sach-sau-sach-nhon-chai-400ml-202407230933002090.jpg", Description = "Nước tẩy trang hiệu quả cho làn da sạch nhờn", Price = 150000 },
                new Product { Id = 2, Name = "Gà dai nhập khẩu Hàn Quốc 1.3kg-1.4kg", ImageUrl = "https://cdnv2.tgdd.vn/bhx-static/bhx/Products/Images/8790/316943/bhx/323328-min_202409251435161115.jpg", Description = "Thịt gà nhập khẩu tươi ngon", Price = 79000 },
                new Product { Id = 3, Name = "2 bàn chải Colgate SlimSoft Flex Clean", ImageUrl = "https://cdn.tgdd.vn/Products/Images/2491/228857/bhx/bo-2-ban-chai-danh-rang-colgate-flex-clean-202402201612311487.jpg", Description = "Bàn chải Colgate làm sạch sâu", Price = 70000 },
                new Product { Id = 4, Name = "Ba rọi heo nhập khẩu 500g", ImageUrl = "https://cdnv2.tgdd.vn/bhx-static/bhx/Products/Images/8781/275806/bhx/325486-min-1_202409091605199273.jpg", Description = "Ba rọi heo nhập khẩu chất lượng cao", Price = 63000 },
                new Product { Id = 5, Name = "Thùng 30 gói mì 3 Miền tôm hùm 65g", ImageUrl = "https://cdn.tgdd.vn/Products/Images/2565/175933/bhx/thung-30-goi-mi-3-mien-tom-hum-65g-202306160838587082.jpg", Description = "Mì 3 Miền tôm hùm thơm ngon", Price = 69000 },
                new Product { Id = 6, Name = "Rau muống hạt 400g", ImageUrl = "https://cdn.tgdd.vn/Products/Images/8820/226916/bhx/rau-muong-hat-400g-202407180929365897.jpg", Description = "Rau muống tươi ngon 400g", Price = 5000 },
                new Product { Id = 7, Name = "Cải bẹ xanh 400g", ImageUrl = "https://cdn.tgdd.vn/Products/Images/8820/318099/bhx/cai-be-xanh-400g-202408021341394360.jpg", Description = "Cải bẹ xanh tươi ngon 400g", Price = 5000 },
                new Product { Id = 8, Name = "Rau dền 400g", ImageUrl = "https://cdn.tgdd.vn/Products/Images/8820/222855/bhx/rau-den-400g-202408021341579064.jpg", Description = "Rau dền tươi ngon 400g", Price = 5000 }
                // Thêm các sản phẩm khác nếu cần
            };

            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }
    }
}
