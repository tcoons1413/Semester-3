*Date: September 16th 2024
##### **Web Architecture Module**
###### **HTTP**
- Works via requests and responses 
- GET - Browser specifies a path and requests. ? and & show in the URL
- POST - Browser specifies a path and provides data in the body of HTTP. ? and & do not show in the URL.
###### **Dynamic HTML**
- Client Side- uses JS + HTML. This code executes on the client side
###### **Server Side Script**
- Generated on the server and sent back to the client as html 
- Can be done via  a Form tag and a method request to a PHP file. 
- Specify with GET and POST
###### **Input Types**

###### **Methods**
**==PHP puts the values into an associative array==**
- GET request 
	- can be cached
	- human readable
- POST request
	- can't be seen by anyone observing the browser URL bar
	- ==**USED IF THE USER IS INPUTTING SENSITIVE INFORMATION**==
	- It does not auto make your information secure 

###### **Multiple HTML Forms**
- Web pages can have multiple HTML Forms
- They can not be nested
###### **Working With HTML Forms Using GET and POST**
- PHP parses http://myserver.com/myapp.php?username=xxx
- **==PHP then puts the values into an associative array==** 
- PHP uses `$_GET` and `$_POST` to parse the data in the URL 
- `$_GET`:
	- data is appended to the URL
	- not secure
	- GET requests can be cached 
- `$_POST`:
	- Data is packaged inside the body of the HTTP Request
	- More secure
	- No data limit
	- Requests are not cached
- We can access this associative array via keys `$_POST["nameFromForm"]` , `$_GET["nameFromForm"]`
###### **NOTE: filter_input() is important**
```php
$username = filter_input(INPUT_GET, "username", FILTER_SANITIZE_SPECIAL_CHARS);

$userage = filter_input(INPUT_GET, "userage", FILTER_VALIDATE_INT);
```
- This will sanitize the data. 
###### **Getting Headers and Other Data**
`` $_SERVER[' HTTP_CONNECTION ']``
`` $_SERVER[' HTTP_USER_AGENT ']``
```php
header("Location: http://www.apple.com")
//Allows us to manipulate the HTTP Response headers
```
###### **==NOTE: Research Headers with PHP

###### **isset()**
- Returns TRUE if a variable is declared and not null
- **From Mike:**
	- Which means 'if this button is clicked, do this'.
- **Example With Form:**

###### **empty()**
- returns TRUE if a variable is not declared, false, or null.
