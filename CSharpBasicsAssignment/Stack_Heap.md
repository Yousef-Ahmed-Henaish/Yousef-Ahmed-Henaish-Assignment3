## Diagram 1: After line 1 (`Order o1 = new Order ...`)

```text
+-------------------+       +----------------------------------+
|      STACK        |       |               HEAP               |
+-------------------+       +----------------------------------+
| o1  --------+     |       | [Address: 0x100]                 |
|             |     |       | Object: Order                    |
+-------------|-----+       | - OrderId: 1                     |
              +-----------> | - CustomerName: "Ali"            |
                            | - IsPaid: false                  |
                            +----------------------------------+
<!-- Create reference variable that contain memory address -->


## Diagram 2: After line 2 (` o2 = o2 ...`)

+-------------------+       +----------------------------------+
|      STACK        |       |               HEAP               |
+-------------------+       +----------------------------------+
| o1  --------+     |       | [Address: 0x100]                 |
|             |     |       | Object: Order                    |
| o2  --+     |     |       | - OrderId: 1                     |
+-------|-----|-----+       | - CustomerName: "Ali"            |
        |     |             | - IsPaid: false                  |
        +-----|-----------> +----------------------------------+
              |
              +-----------> (Same Heap Object)  
<!-- create reference variabel (o2) then make it contain same memory address that is o1 contain => arrow to same object -->


## Diagram 3: After line 3 (` o2.IsPaid = true;`)

+-------------------+       +----------------------------------+
|      STACK        |       |               HEAP               |
+-------------------+       +----------------------------------+
| o1  --------+     |       | [Address: 0x100]                 |
|             |     |       | Object: Order                    |
| o2  --+     |     |       | - OrderId: 1                     |
+-------|-----|-----+       | - CustomerName: "Ali"            |
        |     |             | - IsPaid: **true** (Updated!)    |
        +-----|-----------> +----------------------------------+
              |
              +-----------> (Same Heap Object)
<!-- Change variable inside the object in heap, o1 and o2 arrow to this object, so the statue will change to both -->

<!-- 
    What will change if the variable was a struct ?
        1 - o1 wil contain value not reference.
        2 - o2 = o1, o2 will take copy of o1 value.
        3 - the change will happen inside o2 only
 -->