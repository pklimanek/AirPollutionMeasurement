#include <SoftwareSerial.h>
#include <dht.h>   //dolaczenie biblioteki obslugującej czujnik DHT22

#define dataPin 2 
dht DHT;

unsigned int pm1 = 0;   //deklaracja zmiennych
unsigned int pm2_5 = 0;
unsigned int pm10 = 0;
float tab [5];    //deklaracja tablicy ktora bedzie odczytywal program w VS i zapisywal poszczegolne komorki do bazy danych
void setup() {
  Serial.begin(9600); //ustawienie szybkosci transmisji na 9600 bit/s

}

void loop() {
int index = 0;    //deklaracja zmiennych, ktore posluza do odczytu wartosci z czujnika pylu
char value;
char previousValue;

 int readData = DHT.read22(dataPin); //odczyt warosci z pinu na ktorym podpiety jest czujnik DHT22
 float temperatura = DHT.temperature; //odczyt temperatury
 float wilgotnosc = DHT.humidity;   //odczyt wilgotnosci
  while (Serial.available()) {  //podczas gdy port szeregowy jest aktywny
    value = Serial.read();    //odczyt danych z portu

    //blok warunkowy pozwalajacy na odczyt wartosci stezen poszczegolnych typow pylu i zapis do pierwszych 3 komorek tablicy
    if ((index == 0 && value != 0x42) || (index == 1 && value != 0x4d)){
      break;
    }

    if (index == 4 || index == 6 || index == 8 || index == 10 || index == 12 || index == 14) {
      previousValue = value;
    }
    else if (index == 5) {
      pm1 = 256 * previousValue + value;
      tab[0] = pm1;
    }
    else if (index == 7) {
      pm2_5 = 256 * previousValue + value;
      tab[1] = pm2_5;
    }
    else if (index == 9) {
      pm10 = 256 * previousValue + value;
      tab[2] = pm10;
    } 
    
    index++;

  tab[3] = temperatura; //zapis temperatury i wilgotnosci do kolejnych komorek tablicy
  tab[4] = wilgotnosc;
  }
  delay(600);   //wstawienie opoznienia 600ms
  for(int i = 0; i<5; i++)
  {
    Serial.print(tab[i]);   //wypisanie elementow tablicy na port szeregowy
    Serial.print(";");      //oddzielenie poszczegolnych elementow tablicy srednikami
  }
  
}
