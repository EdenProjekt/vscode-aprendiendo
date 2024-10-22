{
	int n = arr.Count;
	int DiagonalPrincipal = 0;
	int DiagonalSecundaria = 0;

	for (int i = 0; i < n; i++)
	{
		DiagonalPrincipal += arr[i][i];
		DiagonalSecundaria += arr[i][n - i - 1];
	}
	return Math.Abs( DiagonalPrincipal - DiagonalSecundaria );
}