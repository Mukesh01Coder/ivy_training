
// const ages = [33, 12, 20, 16];
// var sub=0;
// //const numbers = [175, 50, 25];
//  var sum = ages.reduce((total, num)=>total+num,0);
//  var sub = ages.reduce((total, num)=>total-num,0);
// // function myFunc() {
// //   return total - num;
// // }
// console.log(sum);
// console.log(sub);







const ages = [33, 12, 20, 16, 5, 54, 21, 44, 61, 13, 15, 45, 25, 64, 32];

const companies= [
    {name: "Company One", category: "Finance", start: 1981, end: 2004},
    {name: "Company Two", category: "Retail", start: 1992, end: 2008},
    {name: "Company Three", category: "Auto", start: 1999, end: 2007},
    {name: "Company Four", category: "Retail", start: 1989, end: 2010},
    {name: "Company Five", category: "Technology", start: 2009, end: 2014},
    {name: "Company Six", category: "Finance", start: 1987, end: 2010},
    {name: "Company Seven", category: "Auto", start: 1986, end: 1996},
    {name: "Company Eight", category: "Technology", start: 2011, end: 2016},
    {name: "Company Nine", category: "Retail", start: 1981, end: 1989}
  ];
// 1. group Retail Companies
  const Retail_Conpanies = companies.filter(company=>company.category=="Retail"?1:0);
  console.log(Retail_Conpanies);

  // 2. group 80's companies
   const Conpanies_1980 = companies.filter(company=>company.start==1980?1:0);
  console.log(Conpanies_1980);

  // 3.companies that lasted for 10years or more
  const Conpanies_10yearsOld = companies.filter(company=>(company.end-company.start)>=10?1:0);
  console.log(Conpanies_10yearsOld);

  // 4map ages*20
  const map_ages = ages.map(age=>age*20);
  console.log(map_ages);

  
  // 5.sort ages both accending and decending order 
  console.log(ages.sort((a,b)=>a-b));
  console.log(ages.sort((a,b)=>b-a));

  //6. get total years for all comapnies

  const total_years_companies = companies.map(company=>`${company.name} is ${company.end-company.start} Years Old`);

  console.log(total_years_companies);

//total years of companies
 var total=0;
for(var x in companies){
   total+=(companies[x].end-companies[x].start);
}
 console.log(total);
 