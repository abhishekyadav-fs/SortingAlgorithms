#Bubble Sort
>Bubble Sort

```
bubbleSort(arr){
  len= arr.Length;
  for(i=0;i<len-1;i++){
    flag = false;
    for(j=0;j<len-i-1;J++){
      if(a[j]>a[j+1]){
        flag = true;
        temp = a[j];
        a[j] = a[j+1];
        a[j+1] = temp;
      }
    }
    if(!flag){
      break;
    }
  }
}
```
