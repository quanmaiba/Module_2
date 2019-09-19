namespace AnimalManagementSystem
{
    interface IAnimal
    {
        int ID { get; set; }
        string Name { get; set; }
        int Age { get; set; }
        void Move();
    }
    interface ITerrestrialAnimal : IAnimal
    {
        void Move();
    }
    interface IMarineAnimal : IAnimal
    {
        void Move();
    }
    class Animal
    {
        private static int id;
        private static int num = 1;
        protected static int ID { get => id; set => id = value; }
        public Animal()
        {
            id = ID + num;
            num++;
        }


    }
}
