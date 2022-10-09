var chocolates = [
    "green", "green", "green", "silver", "blue", "crimson", "purple", "red", "crimson", "purple",
    "purple", "green", "pink", "blue", "red", "silver", "crimson", "purple", "silver", "silver",
    "red", "green", "red", "silver", "pink", "crimson", "purple", "green", "red", "silver",
    "crimson", "pink", "silver", "blue", "pink", "crimson", "crimson", "crimson", "red", "purple",
    "purple", "green", "pink", "blue", "red", "crimson", "silver", "purple", "purple", "purple",
    "red", "purple", "red", "blue", "silver", "green", "crimson", "silver", "blue", "crimson",
    "purple", "green", "pink", "green", "red", "silver", "crimson", "blue", "green", "red",
    "red", "pink", "blue", "silver", "pink", "crimson", "purple", "green", "red", "blue",
    "red", "purple", "silver", "blue", "pink", "silver", "crimson", "silver", "blue", "purple",
    "purple", "green", "blue", "blue", "red", "red", "silver", "purple", "silver", "crimson"
];

//Progression 1: Add ___ chocolates of ____ color
function addChocolates(chocolates,color, count){
    if(count==0) chocolates.unshift("green");
    else{
        for(var i=0;i<count;i++){
            chocolates.unshift(color);
          }
    }
}

//Progression 2: Remove ___ chocolates from the top the dispenser

function removeChocolates(number,chocolates){
   var arr = new Array();
    for(var i in chocolates){
      var cnt=0;
      if(cnt == number) break;
      arr = chocolates.shift();
    }
 return arr;
}
//Progression 3: Dispense ___ chocolates
function dispenseChocolates(number,chocolates){
  var arr1 = new Array(number);
  for(var i=0;i<number;i++){
    arr1[i] = chocolates.pop();
  }
  return arr1;
}

//Progression 4: Dispense ___ chocolates of ____ color
function dispenseChocolatesOfColor(chocolates,number, color){
  var arr2 = new Array();
   for(var ele in chocolates){
      if(ele == color){
         arr2.push(ele);
      }
      if(arr2.length == number) break;
   }
   return arr2;
}

//Progression 5: Display ___ chocolates of each color. Return array of numbers [green, silver, blue, crimson, purple, red, pink]
// Return array of number of chocolates [green, silver, blue, crimson, purple, red, pink]
// Return [1] when called with a single-color array ['green']
// Return [1,2] when called with ['green','red','red']
// Return [] when called with an empty array
function noOfChocolates(){
  var c_green=0;
  var c_red=0;
  var c_purple=0;
  var c_blue=0;
  var c_crimson=0;
  var c_silver=0;
  var c_pink=0;
    
    if(chocolates.length==1) return 1;
    else{
        for(var i in chocolates){
            if(chocolates[i]=="green") c_green++;
            else if(chocolates[i]=="red") c_red++;
            else if(chocolates[i]=="purple") c_purple++;
            else  if(chocolates[i]=="blue") c_blue++;
            else if(chocolates[i]=="crimson") c_crimson++;
            else if(chocolates[i]=="silver") c_silver++;
            else if(chocolates[i]=="pink") c_pink++;
       }
    }
    
    var arr = new Array();
   
    if(c_green!=0)  arr.push(c_green);
    if(c_silver!=0) arr.push(c_silver);
    if(c_blue!=0) arr.push(c_blue);
    if(c_crimson!=0) arr.push(c_crimson);
    if(c_purple!=0) arr.push(c_purple);
    if(c_red!=0)  arr.push(c_red);
    if(c_pink) arr.push(c_pink);
    
   
    return arr;
}

//Progression 6: Sort chocolates based on count in each color. Return array of colors
function sortChocolateBasedOnCount(){
//green,red , purple, blue, crimson, silver, pink
      var m = {};
      for (var i=0;i<chocolates.length;i++) {
          m[str[i]] = 0;
      }
      
      // Loop to store the frequency
      // of a string in a hash-map
      for (var i=0;i<chocolates.length;i++) {
          m[str[i]]++;
      }

      // Iterator for the map
      var vec = new Array(chocolates.length);
      for (var i=0;i<chocolates.length;i++) {
          vec[i] = [];
      }

      var k = 0
      for (var it in m) {
          vec[k] = [m[it], it];
          k += 1;
      }
      vec.sort(cmp);

      function cmp(x, y)
      {
          if (x[0] < y[0]) {
              return -1;
          } 
          else if (x[0] > y[0]) {
            return 1;
          }
          else if (x[0] === y[0])
          {
            if (x[1] < y[1]) {
              return 1;
          }
          else {
              return -1;
          }
        }
      }
   var arr = new Array();

   for (var i = 0; i < k; i++) {
        arr.push(vec[i][1]+", ");
     }
  return arr;
}

//Progression 7: Change ___ chocolates of ____ color to ____ color
function changeChocolateColor(chocolates,number, color, finalColor){
    for(var x in chocolates){
      var cnt = 0;
      if(cnt == number) break;
      if(chocolates[x] == color){
      chocolates[x] = finalColor;
       cnt++;
      }

    }
}

//Progression 8: Change all chocolates of ____ color to ____ color and return [countOfChangedColor, chocolates]
function changeChocolateColorAllOfxCount(chocolates,color, finalColor){
  for(var x in chocolates){
    if(chocolates[x] == color)
    chocolates[x] = finalColor;
  }
}

//Challenge 1: Remove one chocolate of ____ color from the top
function removeChocolateOfColor(color){
  for(var x in chocolates){
    var cnt=0
    if(cnt==1) break;
    if(chocolates[x]==color)
    chocolates.shift();
  }
}

//Challenge 2: Dispense 1 rainbow colored colored chocolate for every 3 chocolates of the same color dispensed
function dispenseRainbowChocolates(number){
  var c_green=0;
  var c_red=0;
  var c_purple=0;
  var c_blue=0;
  var c_crimson=0;
  var c_silver=0;
  var c_pink=0;
    
    if(chocolates.length==1) return 0;
    else{
        for(var i in chocolates){
            if(chocolates[i]=="green") c_green++;
            else if(chocolates[i]=="red") c_red++;
            else if(chocolates[i]=="purple") c_purple++;
            else  if(chocolates[i]=="blue") c_blue++;
            else if(chocolates[i]=="crimson") c_crimson++;
            else if(chocolates[i]=="silver") c_silver++;
            else if(chocolates[i]=="pink") c_pink++;
       }
    }
   return (c_green/3 + c_red/3 +c_purple/3 + c_blue/3 + c_crimson/3 + c_silver/3 + c_pink/3);
}