using CsvHelper;
using CsvHelper.Configuration;
using ImportCSV;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        using (var reader = new StreamReader("C:\\xampp\\htdocs\\file.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var records = new List<RowOrderCSV>();
            csv.Read();
            csv.ReadHeader();
            while (csv.Read())
            {
                var record = new RowOrderCSV();

                record.order_id = csv.GetField<int>("order_id");
                record.address_type = csv.GetField<string>("address_type");
                record.first_name = csv.GetField<string>("first_name");
                record.last_name = csv.GetField<string>("last_name");
                record.company = csv.GetField<string>("company");
                record.address_1 = csv.GetField<string>("address_1");
                record.address_2 = csv.GetField<string>("address_2");
                record.city = csv.GetField<string>("city");
                record.postcode = csv.GetField<string>("postcode");
                record.state = csv.GetField<string>("state");
                record.phone = csv.GetField<string>("phone");
                record.email = csv.GetField<string>("email");
                record.order_item_type = csv.GetField<string>("order_item_type");
                record.product_id = csv.GetField<int>("product_id");
                record.variation_id = csv.GetField<int>("variation_id");
                record.customer_id = csv.GetField<int>("customer_id");
                record.date_created = csv.GetField<string>("date_created");
                record.product_qty = csv.GetField<int>("product_qty");
                record.product_net_revenue = csv.GetField<float>("product_net_revenue");
                record.product_gross_revenue = csv.GetField<float>("product_gross_revenue");
                record.coupon_amount = csv.GetField<int>("coupon_amount");
                record.tax_amount = csv.GetField<float>("tax_amount");
                record.shipping_amount = csv.GetField<float>("shipping_amount");
                record.shipping_tax_amount = csv.GetField<float>("shipping_tax_amount");


                records.Add(record);
                Console.WriteLine(record);
            }
        }
    }
}