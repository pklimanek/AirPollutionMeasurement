using System;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace SerialPortConnection
{
    class Program
    {
        // kolejnosc w lancuchu 
        //PM1 ; PM25 ; PM10 ; temperatura ; wilgotnosc
        static SerialPort _serialPort;
        static void Main(string[] args)
        {

            try
            {
                _serialPort = new SerialPort();
                _serialPort.PortName = "COM6";
                _serialPort.BaudRate = 9600;

                _serialPort.Open();
            }
            catch (Exception e) 
            {
                Console.WriteLine("Wystąpił błąd podczas otwarcie potru");
                Console.WriteLine(e.Message);
            }
            string answer;
            string[] wartosci;
            using (PomiaryContext context = new PomiaryContext())
            {
                for (; ; )
                {

                    for (; ; )
                    {
                        try
                        {
                            Thread.Sleep(3000);
                            answer = _serialPort.ReadExisting();
                            wartosci = answer.Split(';');
                            Console.WriteLine("");
                            if (wartosci.Length > 5)
                                break;
                        }
                        catch (Exception e) 
                        {
                            Console.WriteLine("Wystąpił błąd podczas odczytu informacji z portu RS");
                            Console.WriteLine(e.Message);
                        }

                    }

                    double pm1;
                    double pm25;
                    double pm10;
                    double temp;
                    double wilg;

                    try
                    {
                        pm1 = double.Parse(wartosci[0]);
                        pm25 = double.Parse(wartosci[1]);
                        pm10 = double.Parse(wartosci[2]);
                        temp = double.Parse(wartosci[3]);
                        wilg = double.Parse(wartosci[4]);
                        //Thread.Sleep(1000);

                        if ((pm1 > 100) || (pm1 <= 0))
                        {
                            pm1 = 23;   //przeciętna wartość, która nie wpłynie na resztę wyników przy ich analizie
                        }
                        if ((pm25 > 160) || (pm25 <= 0))
                        {
                            pm25 = 40;
                        }
                        if ((pm10 > 200) || (pm10 <= 0))
                        {
                            pm10 = 45;
                        }
                        if ((temp < -25) || (temp > 45))
                        {
                            if (temp < -25)
                            {
                                temp = 1;
                            }
                            else
                            {
                                temp = 10;
                            }
                        }
                        if ((wilg > 100) || (wilg <= 0))
                        {
                            wilg = 50;
                        }
                        Console.WriteLine("pm1: {0}", pm1);
                        Console.WriteLine("pm25: {0}", pm25);
                        Console.WriteLine("pm10: {0}", pm10);
                        Console.WriteLine("temp: {0}", temp);
                        Console.WriteLine("wilg: {0}", wilg);


                        //INSERT to MeteoDB database
                        Pomiary pomiar = new Pomiary
                        {
                            DataCzas = DateTime.Now,
                            PM1 = pm1,
                            PM25 = pm25,
                            PM10 = pm10,
                            Temperatura = temp,
                            Wilgotnosc = wilg
                        };
                        context.Pomiaries.Add(pomiar);
                        context.SaveChanges();

                        Thread.Sleep(60000);         //uspienie zapisu na 1 min
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Wystąpił błąd podczas konwersji lub zapisu danych do bazy!");
                        Console.WriteLine(e.Message);
                    }


                    
                    //SELECT from MeteoDB database
                    //Pomiary pomiar2 = context.Pomiaries.FirstOrDefault(x => x.Temperatura >= 0);
                    //Console.WriteLine(pomiar2.PomiarID);
                    //Console.Read();



                    //ALTERING data
                    //pomiar2.Wilgotnosc = 72;
                    //context.SaveChanges();
                    //Console.WriteLine(pomiar2);

                    //DELETE from MeteoDB database
                    //Pomiary pomiar3 = context.Pomiaries.FirstOrDefault(x => x.PomiarID <=37);
                    //context.Pomiaries.Remove(pomiar3);
                    //context.SaveChanges();


                }
            }
        }

    }
}


