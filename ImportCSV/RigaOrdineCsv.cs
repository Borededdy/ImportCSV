using System.Text.Json.Serialization.Metadata;

namespace ImportCSV
{
    public class RigaOrdineCsv
    {
        public int order_id { get; set; }
        public string address_type { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set;}
        public string company { get; set; }
        public string address_1 { get; set; }
        public string address_2 { get; set; }
        public string city { get; set; }
        public string postcode { get; set; }
        public string state { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string order_item_type { get; set; }
        public int product_id { get; set; }  
        public int variation_id { get; set }
        public int customer_id { get; set; }
        public string date_created { get; set; }
        public int product_qty { get; set; }
        public float product_net_revenue { get; set; }
        public float product_gross_revenue { get; set; }
        public int coupon_amount { get; set; }
        public float tax_amount { get; set; }
        public float shipping_amount { get; set; }
        public float shipping_tax_amount { get; set; }

        public override string ToString()
        {
            return $"Order: {order_id} Address Type: {address_type} First Name: {first_name} Last Name: {last_name} Company: {company} Address 1: {address_1} Address 2: {address_2} City: {city} Postcode: {postcode} State: {state} Phone: {phone} Email: {email} Order Item Type: {order_item_type} Product id: {product_id} Variation ID: {variation_id} Customer ID: {customer_id} Date Created: {date_created} Product QTY: {product_qty} Product Net Revenue: {product_net_revenue} Product Gross Revenue: {product_gross_revenue} Coupon Amount: {coupon_amount} Tax Amount: {tax_amount} Shipping Amount: {shipping_amount} Shipping Tax Amount: {shipping_tax_amount}";
        }
    }  
}
