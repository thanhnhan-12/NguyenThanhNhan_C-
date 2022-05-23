using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThanhNhan_Lab02
{
    interface IBook
    {
        string this[int index_242]
        {
            get;
            set;
        }

        string Title_242
        {
            get;
            set;
        }

        string Author_242
        {
            get;
            set;
        }

        string Publisher_242
        {
            get;
            set;
        }

        string ISBN_242
        {
            get;
            set;
        }

        int Year_242
        {
            get;
            set;
        }

        void Show();
    }

    class Book : IBook
    {
        private string isbn_242;
        private string title_242;
        private string author_242;
        private string publisher_242;
        private int year_242;

        private ArrayList chapter_242 = new ArrayList();

        public string this[int index_242] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Title_242 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Author_242 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Publisher_242 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ISBN_242 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Year_242 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Show()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {


            Console.ReadKey();
        }
    }
}
