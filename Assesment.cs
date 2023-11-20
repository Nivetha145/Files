//Nivetha S
//Assesment 1:
//Create a Text-file Based System For Storing and Updating Teacher Records:using System
using System;
using System.IO;
using System.Linq;
using System.Collections;
class RainbowSchool{
    static void Main(String[]args){
     Teacher.storing();
     Teacher.Retrive();
     Teacher.Update();
}
}

public class Teacher{
    public static void storing(){
    using(StreamWriter store=File.CreateText(@"C:\\Users\\22632\\b.txt")){
        store.WriteLine("ID     Name        Class       Section");
        store.WriteLine("  ");
        store.WriteLine("1      Abi         First       A");
        store.WriteLine("2      Anu         Second      B");
        store.WriteLine("3      Deva        Third       C");
        store.WriteLine("4      Divya       Fourth      D");
        store.WriteLine("5      Kaviya      Fifth       E");
        store.WriteLine("6      Nivetha     Sixth       F");
        store.WriteLine("7      Priya       Seventh     G");

    }
}
  public static void Retrive(){
        using(StreamReader read=File.OpenText(@"C:\\Users\\22632\\b.txt")){
            string Datas=null;
            while((Datas=read.ReadLine())!=null){
                System.Console.WriteLine(Datas);
            }
}
  }
     public static void  Update(){
        int i=1;
      while(i<=2){
         
         Console.WriteLine("Do you want to 1:Add /n 2:change");
                                               

      int option  = Convert.ToInt32(Console.ReadLine());

      
                    switch (option) 
                    {
                                case 1:
                                   using(StreamWriter sw=File.AppendText(@"C:\\Users\\22632\\b.txt")){
                                        string a=Console.ReadLine();
                                         string b=Console.ReadLine();
                                          string c=Console.ReadLine();
                                          string d=Console.ReadLine();
                                        
                                          sw.WriteLine("{0}      {1}     {2}       {3}",a,b,c,d);
                                            
      
                                   }
                                             Teacher.Retrive();
                                        
                                              break;
                                case 2:
                                           String change = File.ReadAllText(@"C:\\Users\\22632\\b.txt");
                                            change  = change.Replace("ID", "IDS");
                                            File.WriteAllText(@"C:\\Users\\22632\\b.txt", change);
                                            Teacher.Retrive();
                                             break;

                    }
                    
      }
}
}
