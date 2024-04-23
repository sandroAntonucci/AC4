namespace AC3
{
    public interface IConsumDAO
    {
        ConsumAigua GetConsumById(int id);
        public List<ConsumAigua> GetAllConsums();
        void AddConsum(ConsumAigua consum);
        void UpdateConsum(ConsumAigua consum);
        void DeleteConsum(int id);
    }
}