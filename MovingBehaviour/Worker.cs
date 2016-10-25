namespace MovingBehaviourBad
{
    public class Worker
    {
        private WarehouseRequest _warehouseRequest;

        public void DoWork()
        {
            _warehouseRequest = new WarehouseRequest
            {
                WarehouseName = "Barnsley",
                CountryName = "UK"
            };

            var warehouse = ParseEntry();
        }

        private Warehouse ParseEntry()
        {
            return new Warehouse
            {
                Name = _warehouseRequest.WarehouseName,
                Country = _warehouseRequest.CountryName
            };
        }
    }
}