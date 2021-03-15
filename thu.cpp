#include<iostream>
using namespace std;

void xuat_A(float A[])
{
  for(int i=0;i<10;i++){
      cout<<"A["<<i<<"]"<<A[i]<<endl;
  }
}
void xuat_B(float B[]){
      for(int i=0;i<20;i++){
      cout<<"B["<<i<<"]"<<B[i]<<endl;
}
}
void xuat_C(float XX[])
{
    for (int i=0;i<10;i++)
    {
        cout <<" C["<<i<<"] "<<XX[i]<<endl;
    }
}
int main(){  
    float A[10], B[20], C[10];
    for (int i=0;i<10;i++){
    cout<<"Nhap gia tri phan tu thu A["<<i<<"]: ";
    cin>>A[i];
    }
    xuat_A(A);
   for (int i=0;i<20;i++){
    B[i]=(float)i/(i+1);
    cout<<"Gia tri phan tu thu B["<<i<<"]: "<<endl;
    }
    xuat_B(B);
    for (int i=0;i<10;i++)
{
     C[i]=A[i]*B[i]+B[i+1];
}
    xuat_C(C);
  return 0;
}

