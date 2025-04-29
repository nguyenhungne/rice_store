using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using rice_store.models;

namespace rice_store.services
{
    public interface IEmailService
    {
        Task SendRankUpgradeEmailAsync(Customer customer, string oldRank, string newRank);
    }

    public class EmailService : IEmailService
    {
        private readonly IEmailSender _emailSender;

        public EmailService(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public async Task SendRankUpgradeEmailAsync(Customer customer, string oldRank, string newRank)
        {
            string subject = "Thăng hạng thành viên thân thiết GoldenRice Store";
            string body = $@"
                <p>Xin chào <strong>{customer.Name}</strong>,</p>

                <p>Chuỗi cửa hàng gạo <strong>GoldenRice Store</strong> rất vui mừng thông báo rằng bạn đã được <strong>nâng hạng thành viên</strong>!</p>

                <p>
                    Bạn đã được nâng hạng từ <strong>{oldRank}</strong> lên <strong>{newRank}</strong> 🎉<br />
                    Với hạng thành viên mới, bạn sẽ nhận được nhiều ưu đãi và quyền lợi hấp dẫn khi mua hàng từ chúng tôi.
                </p>

                <p>
                    Hãy đến chi nhánh gần nhất để khám phá những ưu đãi đặc biệt dành riêng cho bạn.<br />
                </p>

                <p>
                    Cảm ơn bạn đã tin tưởng và sử dụng dịch vụ của chúng tôi.<br />
                <p/>
                <p>
                    Trân trọng,<br />
                    <strong>GoldenRice Store</strong>
                </p>
            ";

            await _emailSender.SendEmailAsync(customer.Email, subject, body);
        }
    }

}
