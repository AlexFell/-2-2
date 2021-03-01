﻿/* * * * * * * * * * * * * * * *
 *                             *
 *        Лабораторная 2       *
 *                             *
 * Выполнил: Дударов Александр *
 *                             *
 * * * * * * * * * * * * * * * */

using System;

namespace lab2
{
    class DocumentInformation
    {
        private string name;
        private string author;
        private string keywords;
        private string theme;
        private string pathFile;

        public DocumentInformation()
        {}

        public string Name
        {
            get{return name;}
            set{name = value;}
        }

        public string Author
        {
            get{return author;}
            set{author = value;}
        }

        public string Keywords
        {
            get{return keywords;}
            set{keywords = value;}
        }

        public string Theme
        {
            get{return theme;}
            set{theme = value;}
        }

        public string PathFile
        {
            get{return pathFile;}
            set{pathFile = value;}
        }
    }
    class Singleton : DocumentInformation
    {
        public static Singleton Instance
        {
            get
            {
                if (instance == null) instance = new Singleton();
                return instance;
            }
        }
        public virtual void GetInformation()
        {
            Console.WriteLine(Name = "Название файла: ");
            Console.WriteLine(Author = "Автор файла: ");
            Console.WriteLine(Keywords = "Ключевые слова: ");
            Console.WriteLine(Theme = "Тематика: ");
            Console.WriteLine();
        }

        public Singleton() { }
        public Singleton(string pathFile)
        {
            PathFile = pathFile;
        }
        private static Singleton instance;
    }

    class HTML : Singleton
    {
        public HTML()
        {}

        public HTML(string pathFile) : base(pathFile)
        {}

        public override void GetInformation()
        {
            Console.WriteLine("Формат файла: Html");
            Singleton singleton = new Singleton();
            singleton.GetInformation();
            Console.Write($"Путь: {PathFile}");
        }
    }

    class TXT : Singleton
    {
        public TXT()
        {}

        public TXT(string pathFile) : base(pathFile)
        {}

        public override void GetInformation()
        {
            Console.WriteLine("Формат файла: TXT");
            Singleton singleton = new Singleton();
            singleton.GetInformation();
            Console.Write($"Путь: {PathFile}");
        }
    }

    class Excel : Singleton
    {
        public Excel()
        {}

        public Excel(string pathFile) : base(pathFile)
        {}

        public override void GetInformation()
        {
            Console.WriteLine("Формат файла: Excel");
            Singleton singleton = new Singleton();
            singleton.GetInformation();
            Console.Write($"Путь: {PathFile}");
        }
    }

    class Word : Singleton
    {
        public Word()
        {}

        public Word(string pathFile) : base(pathFile)
        {}

        public override void GetInformation()
        {
            Console.WriteLine("Формат файла: Word");
            Singleton singleton = new Singleton();
            singleton.GetInformation();
            Console.Write($"Путь: {PathFile}");
        }
    }

    class PDF : Singleton
    {
        public PDF()
        {}

        public PDF(string pathFile) : base(pathFile)
        {}

        public override void GetInformation()
        {
            Console.WriteLine("Формат файла: PDF");
            Singleton singleton = new Singleton();
            singleton.GetInformation();
            Console.WriteLine($"Путь: {PathFile}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите путь к файлу: ");
            string pathFile = Console.ReadLine();
            Console.WriteLine("Выберите тип файла:\n1) .docx\n2) .pdf\n3) .xlsx\n4) .txt\n5) .html");
            string change = Console.ReadLine();
            switch (change)
            {
                case "1":
                    Word word = new Word(pathFile);
                    word.GetInformation();
                    break;
                case "2":
                    PDF pdf = new PDF(pathFile);
                    pdf.GetInformation();
                    break;
                case "3":
                    Excel excel = new Excel(pathFile);
                    excel.GetInformation();
                    break;
                case "4":
                    TXT txt = new TXT(pathFile);
                    txt.GetInformation();
                    break;
                case "5":
                    HTML html = new HTML(pathFile);
                    html.GetInformation();
                    break;
            }
            Console.ReadKey();
        }
    }
}