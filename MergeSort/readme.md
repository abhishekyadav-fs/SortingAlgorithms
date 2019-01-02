# Merge Sort
> Merge Sort - Recursive

```
MergeSort(arr){
  len = arr.Length;
  if(len<2){
    return arr;
  }
  int mid = len/2;
  int[] left = new int[mid];
  int[] right = new int[len-mid];
  for(i=0 -> mid){
    left[i]= arr[i];
  }
  for(i=mid -> len){
    right[i-mid]= arr[i];
  }
  MergeSort(left);
  MergeSort(Right);
  Merge(left,right,arr);
}
```

> Merging Alogorithm
```
Merge(left,right,arr){
  int i=0,j=0,k=0;
  int ll = left.Length;
  int rl = right.Length;
  while(i<ll && j<rl){
    if(left[i]<right[j]){
      arr[k]= left[i];
      i++;
    }
    else{
      arr[k]= right[j];
      j++;
    }
    k++;
  }
  while(i<ll){
    arr[k]= left[i];
    i++;
    k++;
  }
  while(j<rl){
    arr[k]= right[j];
    j++;
    k++;
  }
}
```
