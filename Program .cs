using System;


namespace TeamProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //instance of the class Holiday
        Holiday holiday1 = new Holiday("Independence Day", 1, "July");
         Holiday holiday2 = new Holiday("Ramadan", 8, "July");
        Console.WriteLine(Holiday.inSameMonth(holiday1._month, holiday2._month));
        //avgDate Method
        Holiday [] holidayArray =  {holiday1, holiday2};
        Console.WriteLine("The average of the two days in the holiday is : " + Holiday.avgDate(holidayArray));
        
         
         // instance of the class Movie
          Movie film = new Movie("Casino Royal", "Eon Productions", "PG13");

            Movie firstMov = new Movie("Casino", "Eon Productions", "PG");
            Movie secondMov = new Movie("Nobody", "Paramount", "PG18");
            Movie thirdMov = new Movie("Black Panther", "Scene One", "PG13");
            Movie fourthMov = new Movie("Lord of the Rings", "Paramount", "PG");
            Movie fifthMov = new Movie("Family Reunion", "Tyler Perry");
            Movie[] movieArray = { firstMov, secondMov, thirdMov, fourthMov, fifthMov };
            Movie.getPG(movieArray);
      
      
      
      
        }
    
       
    }
}
