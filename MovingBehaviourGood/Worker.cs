namespace MovingBehaviourGood
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

            var warehouse = _warehouseRequest.ToWarehouse();
        }
    }
}