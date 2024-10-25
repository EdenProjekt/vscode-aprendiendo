
int alicia = 0;
int bob = 0;
{
for(int i = 0; i < a.Count; i++){
    if (a[i]>b[i])
    alicia++
}
else if (a[i]<b[i]){
    bob++
}
}
return new List<int>{alicia, bob};


//

int n = 0;
int DiagonalPrincipal = 0;
int DiagonalSecundaria = 0;
{
for(int i = 0; i < n; i++){
    DiagonalPrincipal += arr[i][i];
    DiagonalSecundaria += arr[i][i - n - 1];
}
return Math.Abs{DiagonalPrincipal, DiagonalSecundaria};
}