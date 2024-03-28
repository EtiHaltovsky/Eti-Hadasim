// const { request } = require("https");

//function add new treated
function addtreated() {

  let Name = document.querySelector("#Name").value;
  let Id = document.querySelector("#id").value;
  let City = document.querySelector("#city").value;
  let Street = document.querySelector("#street").value;
  let number = document.querySelector("#number").value;
  let DateOfBirth = document.querySelector("#dateOfBirth").value;
  let Phone = document.querySelector("#phone").value;
  let PhoneNumber = document.querySelector("#phonenumber").value;
  let req = new XMLHttpRequest();
  req.open('get', 'https://localhost:44308/api/treated/GetAddNewTreated/' + Name + '/' + Id + '/'
    + City + '/' + Street + '/' + number + '/' + DateOfBirth + '/' + Phone + '/' +
    PhoneNumber, true);
  req.send();
  req.onload = function () {
    if (req.responseText == "-1")
      alert("הלקוח כבר קיים במערכת")
    else {
      alert("נוסף בהצלחה")
      // window.location.href = "activities.html"
    }
  }

}

//function treated retrieval by ID
function updateDetails(Id) {

  // let userID = localStorage.getItem('updateUser');
  // updateDetails(userID);

  // let Id = document.querySelector("#id").value;
  let req = new XMLHttpRequest();
  req.open('get', 'https://localhost:44308/api/treated/GetTreated/' + Id, true);
  req.send();
  req.onload = function () {

    request = JSON.parse(req.response);
    if (req.response != "[]") {
      for (let i = 0; i < request.length; i++) {
        for (let key in request[i]) {
          if (key == id)

            localStorage.setItem('id', request[i][key]);

        }
      }
    }
    console.log(request)
    document.querySelector("#Name").value = request.Name;
    document.querySelector("#id").value = request.Id;
    document.querySelector("#city").value = request.city;
    document.querySelector("#street").value = request.street;
    document.querySelector("#number").value = request.number;
    document.querySelector("#dateOfBirth").value = request.DateOfBirth;
    document.querySelector("#phone").value = request.Phone;
    document.querySelector("#phonenumber").value = request.PhoneNumber;
    
    document.querySelector("#userID").value = request.Id;
  }
}

function onloadPerson() {
  let userID = localStorage.getItem('updateUser');
  updateDetails(userID);
  console.log('userID', userID);
}

// function update
function updateDetailsTreated() {

  let Name = document.querySelector("#Name").value;
  let Id = document.querySelector("#id").value;
  let City = document.querySelector("#city").value;
  let Street = document.querySelector("#street").value;
  let number = document.querySelector("#number").value;
  let DateOfBirth = document.querySelector("#dateOfBirth").value;
  let Phone = document.querySelector("#phone").value;
  let PhoneNumber = document.querySelector("#phonenumber").value;
  let req = new XMLHttpRequest();
  req.open('get', 'https://localhost:44308/api/treated/GetUpdateTreated/' + Name + '/' + Id + '/'
    + City + '/' + Street + '/' + number + '/' + DateOfBirth + '/' + Phone + '/' +
    PhoneNumber, true);
  //שליחת הבקשה
  req.send();
  req.onload = function () {
    request = JSON.parse(req.response);
    console.log(request)
  }
}

//function delete
function Delete() {
  let id = document.querySelector("#id").value;
  Deletetreated(id);
}

//function Deletetreated
function Deletetreated(userID) {
  let req = new XMLHttpRequest();
  req.open('get', 'https://localhost:44308/api/treated/GetDelete/' + userID, true);
  req.send();
  req.onload = function () {
    if (req.responseText == "0")
      alert("הלקוח הוסר מהמערכת");
    else if (req.responseText == "2")
      alert("לא ניתן למחוק לקוח, מקושר לטבלה נוספת");
    document.querySelector("#id").value = "";
  }
}

function ShowAlltreateds() {
  let req = new XMLHttpRequest();

  // שליפת כל המשתמשים
  req.open('GET', 'https://localhost:44308/api/treated/GetAllTreateds/', true);
  req.send();

  req.onload = function () {
    let users = JSON.parse(req.response);
    console.log(users);

    let table = document.createElement('table');
    table.setAttribute('class', 'table table-primary table-bordered table-hover');

    // שורת כותרת
    let headerRow = document.createElement('tr');
    let headers = ["שם פרטי+משפחה", "תעודת זהות", "עיר", "רחוב", "מספר", "תאריך לידה", "טלפון", "טלפון נייד", ""];
    headers.forEach(header => {
      let headerCell = document.createElement('th');
      headerCell.innerHTML = header;
      headerRow.appendChild(headerCell);
    });
    table.appendChild(headerRow);

    // שורות תוכן
    for (let i = 0; i < users.length; i++) {
      let contentRow = document.createElement('tr');

      // עמודות תוכן
      let properties = ["Name", "Id", "City", "Street", "Number", "DateOfBirth", "Phone", "PhoneNumber"];
      properties.forEach(prop => {
        let contentCell = document.createElement('td');
        contentCell.setAttribute('class', 'border');

        contentCell.innerHTML = users[i][prop];
        contentRow.appendChild(contentCell);
      });

      // כפתור "הצג פרטים נוספים"
      let showDetailsButton = document.createElement('button');
      showDetailsButton.innerHTML = 'הצג פרטים נוספים';
      showDetailsButton.addEventListener('click', function () {
        ShowSickDetailsById(users[i].Id); // להחליף לפונקציה המתאימה ולהעביר את המזהה של הלקוח
      });
      let buttonCell = document.createElement('td');
      buttonCell.appendChild(showDetailsButton);
      contentRow.appendChild(buttonCell);

      // כפתור עדכון
      let updateButton = document.createElement('button');
      updateButton.innerHTML = 'עדכון';
      updateButton.addEventListener('click', function () {
        redirectToUpdatePage(users[i].Id);
        //call to update function
        updateDetails(users[i].Id);
        // updateDetailsTreated()
      });
      let updateButtonCell = document.createElement('td');
      updateButtonCell.appendChild(updateButton);
      contentRow.appendChild(updateButtonCell);

      // כפתור מחיקה
      let deleteButton = document.createElement('button');
      deleteButton.innerHTML = 'מחיקה';
      deleteButton.addEventListener('click', function () {
        Deletetreated(users[i].Id);
        ShowAlltreateds()
      });
      let deleteButtonCell = document.createElement('td');
      deleteButtonCell.appendChild(deleteButton);
      contentRow.appendChild(deleteButtonCell);

      // הוספת שורת תוכן לטבלה
      table.appendChild(contentRow);
    }

    document.getElementById('main').appendChild(table);
  }
}

//Go to another page
function redirectToUpdatePage(Id) {
  localStorage.setItem('updateUser', Id);
  window.location.href = 'update.html';
  // window.location.href = 'update.html?id=' + Id;
}

// הצגת פרטי המשתמש כאשר לוחצים על השורה
function showUserDetails(user) {
  alert('פרטי הלקוח: ' + JSON.stringify(user));
}

//A function to retrieve all sicks
function ShowSickDetailsById(Id) {
  let d1
  let req = new XMLHttpRequest();
  req.open('get', 'https://localhost:44308/api/sick/GetSick/' + Id, true);
  req.send();
  req.onload = function () {

    request = JSON.parse(req.response);
    if (req.response != "[]") {
      for (let i = 0; i < request?.length; i++) {
        for (let key in request[i]) {
          if (key == id)

            localStorage.setItem('id', request[i][key]);
          localStorage.setItem('o', i);
        }
      }

      users = JSON.parse(req.response);
      console.log(users);

      let table = document.createElement('table')
      table.setAttribute('class', 'table table-primary table-bordered table-hover')

      //שורת כותרת
      let r = document.createElement('tr');
      //עמודות כותרת
      d1 = document.createElement('th');

      d1 = document.createElement('th');
      d1.innerHTML = "פרטי חולה"
      r.appendChild(d1)

      // d1 = document.createElement('th');
      // d1.innerHTML = "תאריך קבלת חיובי"
      // r.appendChild(d1)

      // d1.innerHTML = "תאריך החלמה"

      r.appendChild(d1)

      table.appendChild(r)

      for (let i = 0; i < users.length; i++) {
        let r = document.createElement('tr');

        d1 = document.createElement('td');
        d1.innerHTML = users[i].Id
        d1.setAttribute('id', 'Id')

        r.appendChild(d1)

        d1 = document.createElement('td');
        d1.innerHTML = users[i].RecivingPositive
        r.appendChild(d1)

        d1 = document.createElement('td');
        d1.innerHTML = users[i].TimeOfRecovery
        r.appendChild(d1)

        table.appendChild(r)
        r.addEventListener('click', function () {
          // במקום הלוגיקה הבאה תוסיף את הקוד שמציג את כל הפרטים של הלקוח
          alert('פרטי הלקוח: ' + JSON.stringify(users[i]));
        });
      }
      let i = localStorage.getItem('updateUser');
      document.getElementById('main').appendChild(table)
      let sickDetails = `ת.ז. ${users.id} היה חולה בין התאריכים: ${getDateFormat(users.recivingPositive)} - ${getDateFormat(users.timeOfRecovery)}`
      document.getElementById('sick').innerHTML = sickDetails;
    }
  }
}

function getDateFormat(date) {
  return date;
  // let x = new Date(date)
  // return `${date.getDate().toString().padStart(2, '0')}/${(date.getMonth() + 1).toString().padStart(2, '0')}/${date.getFullYear()}`;
}


function getUserID(){
  console.log('getUserID******');
  return localStorage.getItem('updateUser');
}

function GetAddNewSick(){
  let Id = document.querySelector("#id").value;
  let RecivingPositive = document.querySelector("#RecivingPositive").value;
  let TimeOfRecovery = document.querySelector("#TimeOfRecovery").value;
  let req = new XMLHttpRequest();
  req.open('get', 'https://localhost:44308/api/sick/GetSick/' + Id+'/'+RecivingPositive+'/'+TimeOfRecovery, true);
  req.send();
  req.onload = function () {
    if (req.responseText == "-1")
    alert("החולה כבר קיים במערכת")
  else {
    alert("נוסף בהצלחה")
    request = JSON.parse(req.response);
}}
}
