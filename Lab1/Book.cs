﻿using System;

namespace Lab1{
    public class Book{

        private string author;
        private string title;
        private string publisher;
        private int pages;
        private int year;

        private static double price = 9;

        public string Author{
            get{ return author; }
            set{ author = value; }
        }
        public string Title{
            get{ return title; }
            set{ title = value; }
        }
        public string Publisher{
            get{ return publisher; }
            set{ publisher = value; }
        }
        public int Pages{
            get{ return pages; }
            set{ pages = value; }
        }
        public int Year{
            get{ return year; }
            set{ year = value; }
        }
        
        static Book(){
            price = 10;
        }
        
        public Book(){
            
        }

        public Book(string author, string title){
            this.author = author;
            this.title = title;
        }

        public Book(string author, string title, string publisher, int pages, int year){
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }
        
        public void SetBook(string author, string title, string publisher, int pages, int year){
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public static void SetPrice(double price){
            Book.price = price;
        }

        public double PriceBook(int s){
            return price * s;
        }

        public void Show(){
            Console.WriteLine("\nКнига:\n Автор: " + author + "\n Название: " + title + 
                              "\n Год издания: " + year + "\n Издательство: " + publisher + 
                              "\n " + pages + " стр.\n Стоимость аренды: " + Book.price);
        }
    }
}
