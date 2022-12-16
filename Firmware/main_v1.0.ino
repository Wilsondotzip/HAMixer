int analogPin = A0;
int InitialValue = 0;

int valA = 0;
int valB = 0;
int valC = 0;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600); 
  InitialValue = map(analogRead(analogPin), 0, 1023, 100, 0);
  Serial.print(InitialValue);
  Serial.print("@1");
  Serial.print("\n");
}

void loop() {
valA = map(analogRead(analogPin), 0, 1023, 100, 0);
delay(1);
valB = map(analogRead(analogPin), 0, 1023, 100, 0);
valC = valA - valB;

 if (valC == -1 || valC == 1){
  Serial.print(valB);
  Serial.print("@1");
  Serial.print("\n");
  }

}
