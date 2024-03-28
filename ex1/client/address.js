// const { number } = require("yargs"); 

function sendRequest() {
    //שליפת השם לשליחה

    let Id = document.querySelector("#id").value;
    let city = document.querySelector("#city").value;
    let Street = document.querySelector("#street").value;
    let num = document.querySelector("#num").value;


    //יצירת קריאה חדשה
    let req = new XMLHttpRequest();
    //פתיחת קריאה חדשה - סוג וכתובת
    req.open('get', 'https://localhost:44308/api/address/GetAddNewAddress/' + Id + '/'
        + city + '/' + Street+'/'+num, true);
    //שליחת הבקשה
    req.send();
    //קבלת התשובה למשתנה req.responseText
    req.onload = function () {
        if (req.responseText == "-1")
            alert("הכתובת כבר קיימת במערכת")
        else {
            alert("נוסף בהצלחה")
            // window.location.href = "activities.html"
        }
    }

}


function updateAddressDetails() {

    let Id = document.querySelector("#id").value;
    let req = new XMLHttpRequest();
    req.open('get', 'https://localhost:44308/api/address/GetAddress/' + Id, true);
    req.send();
    req.onload = function () {
        request = JSON.parse(req.response);
        console.log(request)
        document.querySelector("#id").value = request.Id;
        document.querySelector("#city").value = request.City
        document.querySelector("#street").value = request.Street


    }
}



function updateAddress() {
    //שליפת השם לשליחה

    let Id = document.querySelector("#id").value;
    let city = document.querySelector("#city").value;
    let Street = document.querySelector("#street").value;
    let num = document.querySelector("#num").value;

    //יצירת קריאה חדשה
    let req = new XMLHttpRequest();
    //פתיחת קריאה חדשה - סוג וכתובת
    req.open('get', 'https://localhost:44308/api/address/GetUpdateAddress/' + Id + '/'
        + city + '/' + Street+'/'+num, true);
    //שליחת הבקשה
    req.send();
    //קבלת התשובה למשתנה req.responseText
    req.onload = function () {
        if (req.responseText == "-1")
            alert("לא עודכן")
        else {
            alert("עודכן בהצלחה")
            // window.location.href = "activities.html"
        }
    }

}
function DeleteAddress() {
    let id = document.querySelector("#id").value
    let req = new XMLHttpRequest();
    req.open('get', 'https://localhost:44308/api/address/GetDelete/' + id, true);
    req.send();
    req.onload = function () {
        if (req.responseText == "1")
            alert("הכתובת הוסרה מהמערכת");
        // if (req.responseText == "2")
        // alert("התלמידה רשומה לפעילות, הסירי אותה קודם מהפעילות בטרם המחיקה");
        else if (req.responseText == "0")
            alert("לא נמצאה כתובת ,הקישי שוב");
        // else
        //   alert("תלמידה לא נמחקה, נסי שוב");

    }
}

function changeDetails() {

    let Id = document.querySelector("#id").value;
    let City = document.querySelector("#city").value;
    let Street = document.querySelector("#street").value;

    //יצירת קריאה חדשה
    let req = new XMLHttpRequest();
    //פתיחת קריאה חדשה - סוג וכתובת
    req4.open('get', 'https://localhost:44308/api/user/GetUpdateStudentDetails/' + Id + '/'
        + City + '/' + Street, true);
    req4.send();
    req4.onload = function () {
        document.getElementById("res").innerHTML = req4.responseText;
    }
}

function ShowAlladdresses() {
  
    let req = new XMLHttpRequest()
    //פונקצית שליפה 
    req.open('get', 'https://localhost:44308/api/address/GetAllAddresses/', true)
    req.send();
    req.onload = function () {
        address = JSON.parse(req.response);
        console.log(address);
        let table = document.createElement('table')
        table.setAttribute('class', 'table table-primary table-bordered table-hover')
        //שורת כותרת
        let r = document.createElement('tr');
        //עמודות כותרת


        let d1 = document.createElement('th');
        d1.innerHTML = "תעודת זהות"
        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = "עיר"

        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = "רחוב"
        r.appendChild(d1)

        
        d1 = document.createElement('th');
        d1.innerHTML = "מספר"
        r.appendChild(d1)

        // הוספת שורת כותרת
        table.appendChild(r)

        //שורות תוכן
        for (let i = 0; i < address.length; i++) {
            let r = document.createElement('tr');
            //עמודות תוכן


            //תעודת זהות
            let d1 = document.createElement('td');
            d1.innerHTML = address[i].Id
            r.appendChild(d1)


            //עיר 
            d1 = document.createElement('td');
            d1.innerHTML = address[i].City
            r.appendChild(d1)

            //רחוב
            d1 = document.createElement('td');
            d1.innerHTML = address[i].Street
            r.appendChild(d1)

            d1 = document.createElement('td');
            d1.innerHTML = address[i].num
            r.appendChild(d1)

            // הוספת שורות תוכן
            table.appendChild(r)

        }

        document.getElementById('main').appendChild(table)
    }
    // document.getElementById("message").innerHTML = req.responseText
}