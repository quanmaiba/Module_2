namespace Phone
{
    interface IPhoneBook
    {
        void InsertPhone(string name, int phone);
        void RemovePhone(string name);
        void UpdatePhone(string name, int newphone);
        void SearchPhone(string name);
        void Sort();
    }
}
