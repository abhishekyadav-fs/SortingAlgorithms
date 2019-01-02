# Insertion Sort
>Insertion Sort

```
insertionSort(arr){
  len = arr.Lenght;
  for(i=1 -> len){
    for(j=0 -> i){
      if(arr[j]>arr[i]){
        temp = arr[j];
        arr[j]=arr[i];
        arr[i]=temp;
      }
    }
  }
}

```
