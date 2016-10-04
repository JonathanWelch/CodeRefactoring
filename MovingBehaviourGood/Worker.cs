namespace MovingBehaviourGood
{
    public class Worker
    {
        private CalendarEntryExample _calendarEntryExample;

        public void DoWork()
        {
            _calendarEntryExample = new CalendarEntryExample
            {
                WarehouseName = "Barnsley",
                Country = "UK"
            };

            var calendarEntry = ParseEntry();
        }

        private CalendarEntry ParseEntry()
        {
            return new CalendarEntry
            {
                Warehouse = _calendarEntryExample.WarehouseName,
                Country = _calendarEntryExample.Country
            };
        }
    }
}
