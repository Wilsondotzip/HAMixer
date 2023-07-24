int pot1 = A0;
int pot2 = A1;
int pot3 = A2;
int pot4 = A3;


int pot1Val = 0;
int pot2Val = 0;
int pot3Val = 0;
int pot4Val = 0;

int InitialValue = 0;

int valA = 0;
int valB = 0;
int valC = 0;


void setup() {
  // put your setup code here, to run once:

  
  Serial.begin(9600); 
  bindToSoftware(pot1);
  bindToSoftware(pot2);
  bindToSoftware(pot3);
  bindToSoftware(pot4);

}

void loop() {
pot1Val = checkForUpdate(pot1, pot1Val, 1);
pot2Val = checkForUpdate(pot2, pot2Val, 2);
pot3Val = checkForUpdate(pot3, pot3Val, 3);
pot4Val = checkForUpdate(pot4, pot4Val, 4);

  

}
int checkForUpdate(char pin, char pinval, int ID){
  if(readAv(pin)== pinval)  {}
  else{
  Serial.print(readAv(pin));
  Serial.print("@");
  Serial.print(ID);
  Serial.print("\n");
  return readAv(pin);

    }  
  }
  
int readAv(char pin){
  int i;  
  int sval = 0;

  for (i = 0; i < 5; i++){
    sval = sval + map(analogRead(pin), 0, 4064, 0, 100);
    delay(1);
  }
  sval = sval / 5; 

  return sval;
}
  
char bindToSoftware(char pin){
  InitialValue = map(analogRead(pin), 0, 4064, 0, 100);
  Serial.print(InitialValue);
  Serial.print("@1");
  Serial.print("\n");

  }
