int InitialValue = 0;
int valA = 0;
int valB = 0;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600); 
  Serial.print(InitialValue);
  Serial.print("@1");
  Serial.print("\n");
}

void loop() {
  
if (valB==0||valA==0){
  valB = 0;
  Serial.print(valA);
  Serial.print("@1");
  Serial.print("\n");
  valA++;

    }
    
if (valA==100||valB==1){
  valB = 1;
  Serial.print(valA);
  Serial.print("@1");
  Serial.print("\n");
  valA--;  
      
      }
delay(100);

}
