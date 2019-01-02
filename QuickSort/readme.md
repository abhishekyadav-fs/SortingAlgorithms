# Quick Sort
> Quick Sort
1. Select one pivot element.
2. Push all elements which are smaller than pivot, to left and greater than pivot to right.
3. Now repeat the same thing for right and left subarray.

```
QuickSort(arr,start,end){
  if(start<end){
    int pIndex = Partition(arr,start,end);
    QuickSort(arr,start,pIndex-1);
    QuickSort(arr,pIndex+1,end);
  }
  return arr;
}
```

> Partitioning 
```
Partitionn(arr,start,end){
  pivot = arr[end];
  pIndex = start;
  for(i = start;i<end;i++){
    if(arr[i]<=pivot){
      swap(arr[i],arr[pIndex]);
      pIndex++;
    }
  }
  swap(arr[pIndex],arr[end]);
}
```
