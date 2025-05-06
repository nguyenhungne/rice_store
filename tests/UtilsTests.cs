using System;

using rice_store.utils;

namespace rice_store.Tests
{
    public class UtilsTests
    {
        public static void TestGetRankCustomer()
        {
            var result = CustomerUtils.GetRankCustomer(30_000_000);
            AssertEqual(result, "Kim cương");

            result = CustomerUtils.GetRankCustomer(15_000_000);
            AssertEqual(result, "Vàng");

            result = CustomerUtils.GetRankCustomer(10_000_000);
            AssertEqual(result, "Bạc");

            result = CustomerUtils.GetRankCustomer(5_000_000);
            AssertEqual(result, "Đồng");

            result = CustomerUtils.GetRankCustomer(4_000_000);
            AssertEqual(result, "Thường");
        }

        public static void TestGetTotalAmountAfterDiscount()
        {
            decimal total = 6_000_000m;
            string rank = "Đồng";
            var result = CustomerUtils.GetTotalAmountAfterDiscount(total, rank);
            AssertEqual(result, 5_820_000m);  // 6,000,000 - 3%

            rank = "Bạc";
            result = CustomerUtils.GetTotalAmountAfterDiscount(total, rank);
            AssertEqual(result, 5_700_000m);  // 6,000,000 - 5%

            rank = "Vàng";
            result = CustomerUtils.GetTotalAmountAfterDiscount(total, rank);
            AssertEqual(result, 5_400_000m);  // 6,000,000 - 10%

            rank = "Kim cương";
            result = CustomerUtils.GetTotalAmountAfterDiscount(total, rank);
            AssertEqual(result, 5_100_000m);  // 6,000,000 - 15%

            rank = "Thường";
            result = CustomerUtils.GetTotalAmountAfterDiscount(total, rank);
            AssertEqual(result, 6_000_000m);  // Không giảm giá
        }

        public static void TestGetOriginalTotal()
        {
            string rank;
            decimal discountedTotal;
            decimal result;

            // Đồng: 3%
            rank = "Đồng";
            discountedTotal = 6_000_000m * (1 - 0.03m);  // = 5,820,000
            result = CustomerUtils.GetOriginalTotal(discountedTotal, rank);
            AssertDecimalEqual(result, 6_000_000m);

            // Bạc: 5%
            rank = "Bạc";
            discountedTotal = 6_000_000m * (1 - 0.05m);  // = 5,700,000
            result = CustomerUtils.GetOriginalTotal(discountedTotal, rank);
            AssertDecimalEqual(result, 6_000_000m);

            // Vàng: 10%
            rank = "Vàng";
            discountedTotal = 6_000_000m * (1 - 0.10m);  // = 5,400,000
            result = CustomerUtils.GetOriginalTotal(discountedTotal, rank);
            AssertDecimalEqual(result, 6_000_000m);

            // Kim cương: 15%
            rank = "Kim cương";
            discountedTotal = 6_000_000m * (1 - 0.15m);  // = 5,100,000
            result = CustomerUtils.GetOriginalTotal(discountedTotal, rank);
            AssertDecimalEqual(result, 6_000_000m);

            // Thường: không giảm
            rank = "Thường";
            discountedTotal = 6_000_000m;
            result = CustomerUtils.GetOriginalTotal(discountedTotal, rank);
            AssertDecimalEqual(result, 6_000_000m);
        }

        // Test all methods in CustomerUtils
        public static void TestCustomerUtils()
        {
            TestGetRankCustomer();
            TestGetTotalAmountAfterDiscount();
            TestGetOriginalTotal();
        }

        public static void TestGetMonthNumber()
        {
            AssertEqual(DatetimeUtil.GetMonthNumber("January"), 1);
            AssertEqual(DatetimeUtil.GetMonthNumber("February"), 2);
            AssertEqual(DatetimeUtil.GetMonthNumber("March"), 3);
            AssertEqual(DatetimeUtil.GetMonthNumber("April"), 4);
            AssertEqual(DatetimeUtil.GetMonthNumber("May"), 5);
            AssertEqual(DatetimeUtil.GetMonthNumber("June"), 6);
            AssertEqual(DatetimeUtil.GetMonthNumber("July"), 7);
            AssertEqual(DatetimeUtil.GetMonthNumber("August"), 8);
            AssertEqual(DatetimeUtil.GetMonthNumber("September"), 9);
            AssertEqual(DatetimeUtil.GetMonthNumber("October"), 10);
            AssertEqual(DatetimeUtil.GetMonthNumber("November"), 11);
            AssertEqual(DatetimeUtil.GetMonthNumber("December"), 12);

            try
            {
                DatetimeUtil.GetMonthNumber("InvalidMonth");
                Console.WriteLine("FAIL: Expected ArgumentException for 'InvalidMonth'");
            }
            catch (ArgumentException ex)
            {
                AssertEqual(ex.Message, "Invalid month name.");
            }
        }

        // Run DatetimeUtil tests
        public static void TestDatetimeUtil()
        {
            TestGetMonthNumber();
        }

        public static void TestFormatToVND()
        {
            AssertEqual(MoneyFormatter.FormatToVND(1000), "1,000,000 VND");
            AssertEqual(MoneyFormatter.FormatToVND(2500000), "2,500,000,000 VND");
            AssertEqual(MoneyFormatter.FormatToVND(999999), "999,999,000 VND");
            AssertEqual(MoneyFormatter.FormatToVND(5000), "5,000,000 VND");

            AssertEqual(MoneyFormatter.FormatToVND(0), "0 VND");

            AssertEqual(MoneyFormatter.FormatToVND(-1000), "-1,000,000 VND");

            AssertEqual(MoneyFormatter.FormatToVND(1234.56m), "1,234,560 VND");
        }

        // Run all tests in MoneyFormatter
        public static void TestMoneyFormatter()
        {
            TestFormatToVND();
        }

        public static void TestIsValidEmail()
        {
            // Test valid email addresses
            AssertEqual(ValidEmail.IsValidEmail("test@example.com"), true);
            AssertEqual(ValidEmail.IsValidEmail("user.name@domain.co"), true);
            AssertEqual(ValidEmail.IsValidEmail("user_name123@sub.domain.com"), true);
            AssertEqual(ValidEmail.IsValidEmail("email@domain.com"), true);

            // Test invalid email addresses
            AssertEqual(ValidEmail.IsValidEmail("invalid-email"), false);
            AssertEqual(ValidEmail.IsValidEmail("user@.com"), false);
            AssertEqual(ValidEmail.IsValidEmail("user@domain,com"), false);
            AssertEqual(ValidEmail.IsValidEmail(""), false);
        }

        // Run all tests in ValidEmail
        public static void TestValidEmail()
        {
            TestIsValidEmail();
        }

        public static void AssertEqual<T>(T actual, T expected)
        {
            if (actual.Equals(expected))
            {
                Console.WriteLine($"PASS: {actual} == {expected}");
            }
            else
            {
                Console.WriteLine($"FAIL: {actual} != {expected}");
                throw new Exception($"Test failed: {actual} != {expected}");
            }
        }

        public static void AssertDecimalEqual(decimal actual, decimal expected, decimal tolerance = 0.01m)
        {
            if (Math.Abs(actual - expected) <= tolerance)
            {
                Console.WriteLine($"PASS: {actual} ≈ {expected}");
            }
            else
            {
                Console.WriteLine($"FAIL: {actual} != {expected}");
            }
        }

        // Run all tests
        public static void RunAllTests()
        {
            TestCustomerUtils();
            TestDatetimeUtil();
            TestMoneyFormatter();
            TestValidEmail();
        }
    }
}
