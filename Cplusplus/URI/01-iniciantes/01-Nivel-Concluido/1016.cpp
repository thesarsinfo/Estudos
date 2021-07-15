#include <iostream>
using namespace std;
int Distance(int distance);
int main()//camada view
{
  int distance, timeInterval;
  cout << "Digite a diferença de distancia" << endl;
  cin >> distance;
  timeInterval = Distance(distance);
  cout << timeInterval << " minutos" << endl;
  
}
int Distance(int distance)
{
  int timeInterval;
  timeInterval = distance * 2;
  return timeInterval;
}
