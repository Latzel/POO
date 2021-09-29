#include <iostream>
#include <stdio.h>
#include <math.h>
using namespace std;

int main()
{
	//AXEL DE LA ROSA #LATZEL
	//CAPITULO 2 P.21

	cout << "Factoriza los siguiente trinomios ingresando las debidas variables\n";
    
    cout << "a) 6x^2 + 11x + 3\n" ;
    cout << "b) 5x^2 + 31x + 6\n";
    cout << "c) 10x^2 + 6x - 24\n";
    cout << "d) 2x^2 - 41x - 346\n";


    int a;
    int b;
    int c;

    int x1;
    int x2;

    cout<< "Ingrese el valor de a: ";
    cin >> a;

    cout<< "Ingrese el valor de b: ";
    cin >> b;

    cout<< "Ingrese el valor de c:";
    cin >> c;

    x1 = -b + sqrt (b * b - 4 * a * c) / (2 * a); 
    x2 = -b - sqrt (b * b - 4 * a * c) / (2 * a);
    cout <<"Los valores de x1 y x2 son"<< "\n x1: " << x1 << "\n x2: " << x2 << endl;
    
    
	return 0;
}
