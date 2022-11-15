using Microsoft.EntityFrameworkCore;
using TVSI.XTRADE.BO.API.Models.Enums;

namespace TVSI.XTRADE.BO.API.Models.Entities.Demo;

public class DemoDbContext : DbContext
{
    public DemoDbContext()
    {
    }

    public DemoDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<LogLogin> LogLogins { get; set; }
    public DbSet<ErrorCode> ErrorCodes { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(new User
        {
            UserId = 1,
            Username = "demo",
            Password = "demo".MD5EncodePassword(),
            Email = "demo@netcore.com",
            Phone = "0123456789",
            Address = "Vietnam",
            Pin = "1234"
        });

        modelBuilder.Entity<ErrorCode>().HasData(
            new ErrorCode
            {
                ErrCode = "-99999",
                ErrMsgVi = "Giao dịch thất bại. Vui lòng liên hệ bộ phận chăm sóc khách hàng.",
                ErrMsgEn = "Transactions failed. Please contact customer service.",
                Channel = Channel.All.ToEnumDescription(),
                Descriptions = "",
                Active = true,
                CreatedDate = DateTime.Now,
                CreatedBy = "System"
            },
            new ErrorCode
            {
                ErrCode = "1",
                ErrMsgVi = "Thành công.",
                ErrMsgEn = "Success.",
                Channel = Channel.All.ToEnumDescription(),
                Descriptions = "",
                Active = true,
                CreatedDate = DateTime.Now,
                CreatedBy = "System"
            },
            new ErrorCode
            {
                ErrCode = "69901",
                ErrMsgVi = "Tài khoản đã bị khóa.",
                ErrMsgEn = "Account has been locked.",
                Channel = Channel.All.ToEnumDescription(),
                Descriptions = "",
                Active = true,
                CreatedDate = DateTime.Now,
                CreatedBy = "System"
            },
            new ErrorCode
            {
                ErrCode = "69902",
                ErrMsgVi = "Thông tin đăng nhập không đúng.",
                ErrMsgEn = "Login information is incorrect.",
                Channel = Channel.All.ToEnumDescription(),
                Descriptions = "",
                Active = true,
                CreatedDate = DateTime.Now,
                CreatedBy = "System"
            },
            new ErrorCode
            {
                ErrCode = "69903",
                ErrMsgVi = "Người dùng không có quyền truy cập ứng dụng.",
                ErrMsgEn = "Not allowed to access application.",
                Channel = Channel.All.ToEnumDescription(),
                Descriptions = "",
                Active = true,
                CreatedDate = DateTime.Now,
                CreatedBy = "System"
            },
            new ErrorCode
            {
                ErrCode = "69904",
                ErrMsgVi = "Người dùng không có quyền truy cập hành đông.",
                ErrMsgEn = "Not allowed to access action.",
                Channel = Channel.All.ToEnumDescription(),
                Descriptions = "",
                Active = true,
                CreatedDate = DateTime.Now,
                CreatedBy = "System"
            },
            new ErrorCode
            {
                ErrCode = "69905",
                ErrMsgVi = "Thông tin Token là bắt buộc.",
                ErrMsgEn = "Token is required.",
                Channel = Channel.All.ToEnumDescription(),
                Descriptions = "",
                Active = true,
                CreatedDate = DateTime.Now,
                CreatedBy = "System"
            },
            new ErrorCode
            {
                ErrCode = "69906",
                ErrMsgVi = "Không tìm thấy thông tin Token.",
                ErrMsgEn = "Token not found.",
                Channel = Channel.All.ToEnumDescription(),
                Descriptions = "",
                Active = true,
                CreatedDate = DateTime.Now,
                CreatedBy = "System"
            },
            new ErrorCode
            {
                ErrCode = "69907",
                ErrMsgVi = "Thông tin Token không đúng.",
                ErrMsgEn = "Token invalid.",
                Channel = Channel.All.ToEnumDescription(),
                Descriptions = "",
                Active = true,
                CreatedDate = DateTime.Now,
                CreatedBy = "System"
            }
        );
    }
}