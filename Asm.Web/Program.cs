namespace Asm.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddSession(option =>
            
            option.IdleTimeout = TimeSpan.FromSeconds(30)); // khai báo dịch vụ
            //sessenontime 
            // 1 Phieen làm việc cho tới khi time out sẽ được tính từ khi có request cuối cùng cho tới 
            //khi hết thời gian timeout mà không có tác vụ chèn vào, nếu có , bộ đếm thời gian sẽ reset
            // dữ liệu được lưu vào web sever  
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

           app.UseSession(); //Tạo Seseon
            app.UseRouting();
          
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=User}/{action=Login}"); // set route mặc định về login


            app.Run();
        }
    }
}