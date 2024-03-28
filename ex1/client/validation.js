function validation() {
    // document.getElementById("regForm").addEventListener("submit", function(event) {
    var Name = document.getElementById("Name").value;
    var Id = document.getElementById("Id").value;
    var Address = document.getElementById("Address").value;
    var DateOfBirth = document.getElementById("DateOfBirth").value;
    var Phone = document.getElementById("phone").value;
    var Phonenumber = document.getElementById("phonenumber").value;
    var NumOfVaccination = document.getElementById("NumOfVaccination").value;
  
    // וידוא שהשדה לא ריק
    if (Name === "" || Id === "" || Address === "" || DateOfBirth === "" || Phone === "" || Phonenumber === "" || NumOfVaccination === "") {
      alert("אנא מלא את כל השדות");
      event.preventDefault();
      return;
    }
  
    // וידוא תקינות שם - רק אותיות בעברית ורווחים
    if (!/^[א-ת\s]+$/.test(Name)) {
      alert("שם לא תקין, אנא הכנס רק אותיות בעברית ורווחים");
      event.preventDefault();
      return;
    }
  
    // וידוא תקינות תעודת זהות - תווים מספריים בלבד ובאורך של 9 תווים
    if (!/^\d{9}$/.test(Id)) {
      alert("תעודת זהות אינה תקינה, אנא הכנס 9 ספרות בלבד");
      event.preventDefault();
      return;
    }
  
    // וידוא תקינות מספר טלפון נייד ומספר טלפון
    if (!/^\d{9,10}$/.test(Phone)) {
      alert("מספר הטלפון לא תקין, אנא הזן 9 או 10 ספרות");
      event.preventDefault();
      return;
    }
  
    // וידוא תקינות מספר חיסון - ספרה בודדת
    if (!/^\d{1}$/.test(NumOfVaccination)) {
      alert("מספר חיסון אינו תקין, אנא הזן ספרה בודדת");
      event.preventDefault();
      return;
    }
  
    // וידוא תקינות תאריך לידה - עבור הדוגמה, נבדוק רק שהשדה אינו ריק
    if (DateOfBirth === "") {
      alert("תאריך לידה הינו שדה חובה");
      event.preventDefault();
      return;
    }
  
    // אם התוכנית מגיעה לכאן, זה אומר שכל הוזנו נכון והטופס יישלח
    addtreated();
    alert("הטופס נשלח בהצלחה!");
  }
