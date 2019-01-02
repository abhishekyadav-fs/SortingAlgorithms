# Selection Sort
>Selection Sort

Iterate through the entire array and in each iteration select the smallest element, put in appropirate place.
This can be done using temp array and finally copying the element fron temp array to orginal array.

```
selection(A,n)
 {
  for(i=0 -> n-1)
  {
    imin = i;
    for(j=i+1 -> n){
      if(a[imin]<A[j]
      {
        imin = j;
      }
    }
    temp = A[i];
    A[i] = A[imin];
    A[imin] = temp;
  }
 }
```
