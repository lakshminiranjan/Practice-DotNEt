# Practice-DotNEt


---

### **1. Basic LINQ: Retrieving Data**
This is the simplest operation. LINQ allows you to filter and retrieve data from collections like lists or arrays.

#### Example:
Imagine you have a list of numbers, and you want to get all even numbers:
```csharp
var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

var evenNumbers = numbers.Where(num => num % 2 == 0);

Console.WriteLine("Even numbers:");
foreach (var num in evenNumbers)
{
    Console.WriteLine(num);
}
```

**Explanation:**
- `Where`: Filters the collection based on a condition (here, numbers divisible by 2).
- You simply use a lambda expression (`num => num % 2 == 0`) to define the filter.

---

### **2. Transformation: `Select`**
This lets you transform each item in a collection into something else.

#### Example:
If you want to double every number in a list:
```csharp
var numbers = new List<int> { 1, 2, 3, 4, 5 };

var doubledNumbers = numbers.Select(num => num * 2);

Console.WriteLine("Doubled numbers:");
foreach (var num in doubledNumbers)
{
    Console.WriteLine(num);
}
```

**Explanation:**
- `Select`: Projects each item to a new value (here, multiplying each number by 2).

---

### **3. Flattening Collections: `SelectMany`**
This is used to combine or flatten nested collections into a single collection.

#### Example:
You have a list of orders, and each order has multiple products. You want to get all products as one list:
```csharp
var orders = new List<Order>
{
    new Order { Id = 1, Product = new List<string> { "Product A", "Product B" } },
    new Order { Id = 2, Product = new List<string> { "Product C", "Product D" } }
};

var allProducts = orders.SelectMany(order => order.Product);

Console.WriteLine("All products:");
foreach (var product in allProducts)
{
    Console.WriteLine(product);
}
```

**Explanation:**
- `SelectMany`: Flattens the `Product` lists from each order into a single list.

---

### **4. Aggregation: `Sum`, `Average`, `Count`, etc.**
LINQ can also be used to aggregate data from a collection.

#### Example:
Get the total of numbers in a list:
```csharp
var numbers = new List<int> { 10, 20, 30 };

var total = numbers.Sum();

Console.WriteLine($"Total sum: {total}");
```

**Explanation:**
- `Sum`: Adds all the numbers in the list.
- Similar methods: `Average` (calculate mean), `Count` (count items), etc.

---

### **5. Combining Collections: `Zip`**
This is used to combine two collections into one based on positions.

#### Example:
If you have two lists—names and ages—and want to combine them:
```csharp
var names = new List<string> { "Alice", "Bob" };
var ages = new List<int> { 25, 30 };

var nameAgePairs = names.Zip(ages, (name, age) => $"{name} is {age} years old");

foreach (var pair in nameAgePairs)
{
    Console.WriteLine(pair);
}
```

**Explanation:**
- `Zip`: Combines `names` and `ages` by position, creating pairs.

---

### **6. Sorting: `OrderBy` and `ThenBy`**
Sort collections based on values.

#### Example:
Sort numbers in ascending order:
```csharp
var numbers = new List<int> { 5, 1, 3, 2, 4 };

var sortedNumbers = numbers.OrderBy(num => num);

Console.WriteLine("Sorted numbers:");
foreach (var num in sortedNumbers)
{
    Console.WriteLine(num);
}
```

**Explanation:**
- `OrderBy`: Sorts values.
- Use `ThenBy` for secondary sorting conditions.

---

### **7. Advanced Filtering: `Skip` and `Take`**
This lets you skip a certain number of items and then take the next items.

#### Example:
Get the second and third numbers:
```csharp
var numbers = new List<int> { 1, 2, 3, 4, 5 };

var result = numbers.Skip(1).Take(2);

Console.WriteLine("Second and third numbers:");
foreach (var num in result)
{
    Console.WriteLine(num);
}
```

**Explanation:**
- `Skip`: Skips the first item(s).
- `Take`: Selects the next item(s).

---

### **8. Complex LINQ Queries**
Combine multiple LINQ methods for more complex scenarios.

#### Example:
Get distinct products sorted alphabetically from orders:
```csharp
var orders = new List<Order>
{
    new Order { Id = 1, Product = new List<string> { "Product B", "Product A" } },
    new Order { Id = 2, Product = new List<string> { "Product C", "Product B" } }
};

var distinctSortedProducts = orders.SelectMany(order => order.Product)
                                   .Distinct()
                                   .OrderBy(product => product);

Console.WriteLine("Distinct sorted products:");
foreach (var product in distinctSortedProducts)
{
    Console.WriteLine(product);
}
```

**Explanation:**
- `SelectMany`: Flattens the collection.
- `Distinct`: Removes duplicates.
- `OrderBy`: Sorts the values.

---

### **Final Tips for Beginners:**
1. **Start simple:** Use `Where` and `Select` to filter or transform collections.
2. **Understand collections:** LINQ works on IEnumerable, like lists or arrays.
3. **Combine methods:** As you grow comfortable, chain LINQ methods to handle complex scenarios.
4. **Practice:** Play around with small data sets and explore different LINQ methods.




Here's a **comprehensive list of LINQ built-in methods** in C#, including both the previously discussed methods and others that were missed, such as **Concat**:

---

### **Grouping and Merging Methods**:
1. **Concat**:
   - Combines two sequences into one.
   - Example:
     ```csharp
     var list1 = new[] { 1, 2, 3 };
     var list2 = new[] { 4, 5, 6 };
     var combined = list1.Concat(list2); // Result: { 1, 2, 3, 4, 5, 6 }
     ```

2. **Union**:
   - Combines two sequences and removes duplicates.
   - Example:
     ```csharp
     var union = list1.Union(list2); // Result: { 1, 2, 3, 4, 5, 6 }
     ```

3. **Intersect**:
   - Returns common elements in two sequences.
   - Example:
     ```csharp
     var intersect = list1.Intersect(list2); // Result: { }
     ```

4. **Except**:
   - Returns elements from the first sequence that are not in the second.
   - Example:
     ```csharp
     var except = list1.Except(list2); // Result: { 1, 2, 3 }
     ```

---

### **Sorting Methods**:
1. **OrderBy**:
   - Sorts elements in ascending order.
   - Example: `numbers.OrderBy(x => x)`.

2. **OrderByDescending**:
   - Sorts elements in descending order.
   - Example: `numbers.OrderByDescending(x => x)`.

3. **ThenBy**:
   - Adds secondary sorting in ascending order.
   - Example: `numbers.OrderBy(x => x).ThenBy(x => x % 2)`.

4. **ThenByDescending**:
   - Adds secondary sorting in descending order.
   - Example: `numbers.OrderBy(x => x).ThenByDescending(x => x % 2)`.

---

### **Projection Methods**:
1. **Select**:
   - Projects each element into a new form.
   - Example: `numbers.Select(x => x * 2)`.

2. **SelectMany**:
   - Flattens a collection of collections into a single collection.
   - Example: `lists.SelectMany(list => list)`.

---

### **Filtering Methods**:
1. **Where**:
   - Filters elements based on a predicate.
   - Example: `numbers.Where(x => x > 5)`.

2. **OfType**:
   - Filters elements based on type.
   - Example: `mixedList.OfType<int>()`.

---

### **Element Retrieval Methods**:
1. **First**:
   - Returns the first element; throws an exception if none exist.
   - Example: `numbers.First(x => x > 5)`.

2. **FirstOrDefault**:
   - Returns the first element; returns default value if none exist.
   - Example: `numbers.FirstOrDefault(x => x > 5)`.

3. **Last**:
   - Returns the last element; throws an exception if none exist.
   - Example: `numbers.Last()`.

4. **LastOrDefault**:
   - Returns the last element; returns default value if none exist.
   - Example: `numbers.LastOrDefault()`.

5. **Single**:
   - Returns exactly one element; throws an exception if there's not exactly one match.
   - Example: `numbers.Single(x => x == 5)`.

6. **SingleOrDefault**:
   - Returns exactly one element; returns default value if none exist.
   - Example: `numbers.SingleOrDefault(x => x == 5)`.

7. **ElementAt**:
   - Returns the element at a specified index.
   - Example: `numbers.ElementAt(2)`.

8. **ElementAtOrDefault**:
   - Returns the element at a specified index; returns default if index is out of bounds.
   - Example: `numbers.ElementAtOrDefault(10)`.

---

### **Set Methods**:
1. **Distinct**:
   - Removes duplicates.
   - Example: `numbers.Distinct()`.

2. **DefaultIfEmpty**:
   - Returns a default value if the sequence is empty.
   - Example: `numbers.DefaultIfEmpty(-1)`.

---

### **Aggregate Methods**:
1. **Aggregate**:
   - Applies a custom aggregation function.
   - Example: `numbers.Aggregate((a, b) => a + b)`.

2. **Sum**:
   - Calculates the sum of elements.
   - Example: `numbers.Sum()`.

3. **Average**:
   - Computes the average of elements.
   - Example: `numbers.Average()`.

4. **Min**:
   - Finds the minimum value.
   - Example: `numbers.Min()`.

5. **Max**:
   - Finds the maximum value.
   - Example: `numbers.Max()`.

6. **Count**:
   - Counts the elements in a sequence.
   - Example: `numbers.Count(x => x > 5)`.

---

### **Partition Methods**:
1. **Take**:
   - Retrieves a specified number of elements.
   - Example: `numbers.Take(3)`.

2. **Skip**:
   - Skips a specified number of elements.
   - Example: `numbers.Skip(3)`.

---

### **Quantifier Methods**:
1. **Any**:
   - Checks if any element satisfies a condition.
   - Example: `numbers.Any(x => x > 5)`.

2. **All**:
   - Checks if all elements satisfy a condition.
   - Example: `numbers.All(x => x > 5)`.

3. **Contains**:
   - Checks if a sequence contains a specific element.
   - Example: `numbers.Contains(5)`.

---

### **Conversion Methods**:
1. **ToList**:
   - Converts a sequence to a list.
   - Example: `numbers.ToList()`.

2. **ToArray**:
   - Converts a sequence to an array.
   - Example: `numbers.ToArray()`.

3. **ToDictionary**:
   - Converts a sequence to a dictionary.
   - Example: `people.ToDictionary(p => p.Id)`.

4. **ToHashSet**:
   - Converts a sequence to a HashSet (removes duplicates).
   - Example: `numbers.ToHashSet()`.

---

### Why These Methods Are Used:
- **Simplify Code**: LINQ reduces boilerplate code for data processing tasks.
- **Expressiveness**: Enables declarative querying with functional programming concepts.
- **Performance**: Built-in methods are optimized and make querying efficient.
- **Versatility**: LINQ works with different data sources like arrays, lists, databases, and XML.





A single file uploader is there in asp. Net mvc application,  here instead of single file upload I need to have 3 file uploads and after 3 uploads if any other file uploaded last file should go and the uploaded 4th file should the 3rd file now. Code is uploaded in images. Can we achieve the requirement only changing in html and javascript, if yes give that code if no do minimal changes in c Sharp code and all please

You want to allow uploading up to three files in your ASP.NET MVC application, replacing the oldest file each time a fourth file is added (a “rolling” 3-file uploader). You’d like to know if this can be achieved just with HTML and JavaScript, and if not, what minimal C# changes are needed.

## Can it be done with only HTML and JavaScript?

**No, not fully.**  
While you can use HTML and JS to let users select and queue files on the client, in a standard HTML `<input type="file" multiple>`, the actual uploading and backend management (such as storing only three files per record, evicting the oldest, etc.) requires backend logic in C#.

However, you can make most UI/UX changes on the front end, and only minimal changes are required on the server.

***

## Solution Overview

### 1. Front-End (HTML & JavaScript)
- Show a file input that allows only one file per selection, a display area showing the list of up to three uploaded files.
- Keep a JS array to manage the current “queue.”
- When a file is uploaded, add it to the array. If more than three, remove (and optionally delete) the first/oldest.
- POST files to the server one at a time or all together.

### 2. Back-End (C# Controller/Model)
- Accept a list/array of files (`IFormFile[]` or similar).
- Store, and if there are more than three, remove the oldest per your logic.

***

## HTML & JavaScript (Client-Side)

```html
<div id="uploadedFilesList"></div>
<div class="input-group mb-2">
    <!-- No 'multiple'! Enforce 1 file at a time -->
    <input type="file" id="fileInput" accept="application/pdf" style="display: none;" onchange="handleFileSelect(this)" />
    <label class="btn btn-outline-secondary mb-0" for="fileInput">Browse</label>
</div>
<button type="button" id="uploadBtn" class="g-btn" onclick="uploadFile()" disabled>Upload</button>

<script>
    let uploadedFiles = [];

    function handleFileSelect(input) {
        const file = input.files[0];
        if (!file || file.type !== "application/pdf") {
            alert("Select a PDF file!");
            input.value = '';
            document.getElementById('uploadBtn').disabled = true;
            return;
        }
        document.getElementById('uploadBtn').disabled = false;
    }

    function uploadFile() {
        const input = document.getElementById('fileInput');
        const file = input.files;
        if (!file) return;

        if (uploadedFiles.length === 3) {
            // Remove oldest (first) file
            uploadedFiles.shift();
        }
        uploadedFiles.push(file);
        updateUploadedFilesList();

        // Optionally, upload immediately:
        // uploadToServer(uploadedFiles);

        input.value = '';
        document.getElementById('uploadBtn').disabled = true;
    }

    function updateUploadedFilesList() {
        const list = document.getElementById('uploadedFilesList');
        list.innerHTML = "";
        uploadedFiles.forEach((f, idx) => {
            const div = document.createElement('div');
            div.innerText = (idx+1) + ". " + f.name;
            list.appendChild(div);
        });
    }

    // Optional: Function to upload to server
    function uploadToServer(files) {
        let formData = new FormData();
        files.forEach(f => formData.append('files', f)); // 'files' is array

        fetch('/Your/Upload/Endpoint', {
            method: 'POST',
            body: formData
        }).then(r => {
            // handle result
        });
    }
</script>
```

***

## Minimal Server-Side (C#) Changes

**On the backend**, ensure that your upload endpoint (`Upload` action) can accept an array of files (up to three). If you send all three at once, change the signature to:

```csharp
[HttpPost]
public ActionResult Upload(List<HttpPostedFileBase> files, int answerSetId)
{
    // Only keep latest 3 files (if more sent, take last 3)
    var filesToStore = files.TakeLast(3).ToList();

    // Save files. You'll need to store them with info to know their order.
    foreach (var file in filesToStore)
    {
        if (file != null && file.ContentLength > 0)
        {
            // Save file - your logic here
        }
    }

    // Remove old files if necessary
    // Respond with a success indication
    return Json(new { success = true });
}
```

### If you want “Upload Each File Immediately”  
Process each file as it comes in, and keep track of the number and the order in your DB/model; delete the oldest when a new one is added and there are already three.

***

### Summary Table

| Front-End | Back-End (C#) |
|-----------|---------------|
| Limit selection & display, restrict to 3, rolling. | Accept array of files, keep latest 3, delete oldest. |
| JS manages queue UI. | Remove old files in storage/database. |

***

**In conclusion:**  
- Most user interaction and logic can be handled with JS and some HTML.
- Minimal backend changes are needed: accept list of files and enforce “max 3, rolling” logic during storage.  
- If you're storing file metadata in the model, add a collection/list of files and manage their addition/removal accordingly.

Let me know if you want the full C# controller code with the above scenario, or any further integration advice!

Citations:
[1] T-3001-Test.txt https://ppl-ai-file-upload.s3.amazonaws.com/web/direct-files/attachments/12938409/1d18966f-1083-4acb-ba2f-0066cedefb23/T-3001-Test.txt
[2] selected_image_3182816908821823823.jpg https://ppl-ai-file-upload.s3.amazonaws.com/web/direct-files/attachments/images/12938409/a21ffc3e-e8e3-4b4e-9d64-0068ce18bd41/selected_image_3182816908821823823.jpg?AWSAccessKeyId=ASIA2F3EMEYE7LXCZXA6&Signature=G%2FLFUl1qUO6%2FNoPdwVBE7KIcGOQ%3D&x-amz-security-token=IQoJb3JpZ2luX2VjEHUaCXVzLWVhc3QtMSJHMEUCID410YWNKfRWnZ0XO2IxnAxYGILydWCH1b6%2Fzn72msY7AiEA8ELm7ijGolmWBGP55yLDtuTaL2G8J3k%2BPZAesNt7Frwq%2BgQIvv%2F%2F%2F%2F%2F%2F%2F%2F%2F%2FARABGgw2OTk3NTMzMDk3MDUiDIJV7rfLdCWLNUxa%2FirOBH7rlZOSAEujOFAHVlLbC62B4UwtZtjTwEFmNH7QSeJ08ryfwpOCOVAOncl5wBOT70kouzmr7L03c8YKCQZg20w1uK0FRqVvqu%2FsBODj2ILk%2BatFOL2gyUCutKm2PsTbkaer3KU5R6f2bpsK3ICFVCm4dPKchAAaxozHXBpl7OyT%2Bfu4pjMAISUirdCdn%2BrGWSC%2FVEyj7zyH%2FbQT7kUcLz1%2BnxjKM2cIV5vHLMqkuVW04ConuXhCXOsQJ3dC6v5wpo6nxBz0lecUYwpJSd4QCFMpqhCWNEyhLzLTqqW%2FOspoZdHXb98eOelCwe7nh%2BMno8FCbgaeGYArdCuy9qEKM9%2FiGY8qkhZzonUIfI2W7%2BmmEEWAU%2BPT6yDVONMhERsEr1m9wEpJ2YoNdNyP6FbtPr8fxucGG5xXEgdwwGe2N3%2FaEFSWUTj89hfclpBj6i%2BPO8uULJ3ekUW17eGF5yXNYib1CsJ1ks38L5qwGvmTM9FLrZ59sKnpBL181NG4bab8ueARhPVWuKkSAsrV8OU9LOcRBpEw9PU%2FajLp4GStaPuVgih6ZSFhXILUNf7vV%2BCRHBCE0ayIF1jr13M3R40h7YYFPCi1lt5tOTvxaIeq43ZNAdJsL9nggbQcuHCpWC0UPpBsxEcVRspAYfeKcKj6ZGyPbrIjFZXwuSiR%2B3UDJK8dcLNQ1ONcJyAeeCu0DQsbUzKKRZqNbTFmSL0sRfPxCU84nv1OX5H4CFe9MJZgvNqMUyqvb2Hdga03G4Aq0qKVP4HpD9YY80frq0VC6zUIMK%2FhkcUGOpoBevYsUV8hFmFrnWCsib0o0q6a%2Bbj0R0R0EKUpxEq6gW1b2hyJ1lfOkhZAskeQpwEDMN3RONtwmyueL8dQAR6%2BD2KwTWsPP%2FqXGUB%2BhATQzqz4SxSWNFU56QXHafBWJhE%2BeZKjQB3QB5vb5KcuYiPR3obkzfgo7liJGjG%2F3rR5DYgLAvBLTV17Yu3a127wC9c56hOZL8e6zcLiwA%3D%3D&Expires=1755608656





