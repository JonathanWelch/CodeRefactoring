namespace MovingBehaviourGood
{
    public class WarehouseRequest
    {
        public string WarehouseName { get; set; }
        public string CountryName { get; set; }

        public Warehouse ToWarehouse()
        {
            return new Warehouse
            {
                Name = WarehouseName,
                Country = CountryName
            };
        }
    }
}
