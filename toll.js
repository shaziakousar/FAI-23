function calculateToll(){
    const regNumber = document.getElementById("txtNumber").value;
    const Category = document.getElementById("TypeVeh").value;
    let toll=0;
    if(Category === "option1"){
        toll=30;
    } else if(Category==="option2"){
        toll=50;
    }
    else if(Category==="option3"){
        toll=60;
    }
    else if(Category==="option4"){
        toll=70;
    }
    
 }


class vehicles{
    constructor(no,type,amt) {
        this.no= no;
        this.type = type;
        this.amt = amt;
    }
}
class AmtManager {
    vehicles = [];
    getData() {
        if (localStorage.getItem("PRICE") != undefined) {

            this.expenses = JSON.parse(localStorage.getItem("PRICE"));
        }
    }

    addNewExpense = (ex) => {
        this.getData();
        this.expenses.push(ex);
        localStorage.setItem("PRICE", JSON.stringify(this.vehicles));
    }  
}

