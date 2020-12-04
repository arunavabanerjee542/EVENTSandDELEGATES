using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVENTSandDELEGATES
{
    // here the Satellite class acts as a publisher 
    // rest all classess acts as subscribers 




    class Program
    {
        static void Main(string[] args)
        {
            SatellitePublisher s = new SatellitePublisher();
            BBCnews b = new BBCnews();
            CNNnews c = new CNNnews();
            NewYorkTimes n = new NewYorkTimes();

            s.takeevent += b.BBCcast;
            s.takeevent += c.CNNcast;
            s.takeevent += n.NewYorkTimescast;

            s.broadcast();



        }
    }



    class SatellitePublisher
    {
        public delegate void takemycontent();

        public event takemycontent takeevent;

        public void broadcast()
        {
            Console.WriteLine(" satellite broadcast ");
            cast();
        }


        protected virtual void cast()
        {
            takeevent();
        }




    }


    class BBCnews
    {
        public void BBCcast()
        {
            Console.WriteLine(" BBC casting is SUCCCESSFUL ");

        }


    }


    class CNNnews
    {
        public void CNNcast()
        {
            Console.WriteLine(" CNN casting is SUCCCESSFUL ");

        }


    }


    class NewYorkTimes
    {

        public void NewYorkTimescast()
        {
            Console.WriteLine(" NewYorkTimes casting is SUCCCESSFUL ");

        }


    }











}
