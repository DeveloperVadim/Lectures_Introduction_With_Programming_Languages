int Max(int arg1,int arg2,int arg3)
{
    int result=arg1;
    if (arg2>result) result=arg2;
    if (arg3>result) result=arg3;
    return result;
}
int a1=19;
int b1=28;
int c1=371;
int a2=46;
int b2=55;
int c2=64;
int a3=73;
int b3=83;
int c3=91;

int max=Max(
    Max(a1,b1,c1),
    Max(a2,b2,c2),
    Max(a3,b3,c3));



// int max1=Max(a1,b1,c1);
// int max2=Max(a2,b2,c2);
// int max3=Max(a3,b3,c3);
// int max=Max(max1,max2,max3);



// int max=a1;
// if (max<b1) max=b1;
// if (max<c1) max=c1;

// if (max<a2) max=a2;
// if (max<b2) max=b2;
// if (max<c2) max=c2;

// if (max<a3) max=a3;
// if (max<b3) max=b3;
// if (max<c3) max=c3;

Console.WriteLine(max);