# MRP_SYSTEM
In our MRP SYSTEM application, the aim is to have items with a certain id and to keep these items in a minimum amount in our warehouse.
We can sell as many of these items to our customers as they want, under certain rules. Also, we can order for our warehouse with under certain rules. For example, if LOT SIZING RULE=L4L, we can sell or order any amount of product; but if LOT SIZING RULE=Multiples of 40, we can only sell or order products in amount is 40 or multiples of 40. If LOT SIZING RULE=Multiples of 40; We cannot sell or order a product that has amount is 50!
Some items may require a certain amount of other items to be produced. If we need sub-products, we can order as many products as specified in the LOT SIZING RULE field.
#### <br/>
![UML](https://github.com/KeremTAN/MRP_SYSTEM/blob/master/img/i1.png)
<br/>
As can be seen here, since item 1605 has lot size rule = L4L, we can place as many sales orders as we want.
<br/>
![UML](https://github.com/KeremTAN/MRP_SYSTEM/blob/master/img/i2.png)
![UML](https://github.com/KeremTAN/MRP_SYSTEM/blob/master/img/i3.png)
![UML](https://github.com/KeremTAN/MRP_SYSTEM/blob/master/img/i4.png)
![UML](https://github.com/KeremTAN/MRP_SYSTEM/blob/master/img/i5.png)
![UML](https://github.com/KeremTAN/MRP_SYSTEM/blob/master/img/i6.png)
