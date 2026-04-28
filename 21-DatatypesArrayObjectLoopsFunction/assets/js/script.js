// Task 1
// let nums = [10, 2, 21, 22, 2, 11, 33, 33];
// let count = 0;
// for (let i = 0; i < nums.length; i++) {
//     for (let j = i+1; j < nums.length; j++) {
//         if (nums[i] == nums[j]) {
//             nums.splice(j,1)
//             count++;
//             j--;
//         }
//     }
// }
// console.log(count) 

//Task 2 - serte gore eslinde hazir soz verilmelidi amma daha interaktiv olsun deye daxil edile bilen hala getirdim.
// let word = prompt("Bir soz daxil edin");
// let reverse = '';

// for(let i = word.length - 1 ; i >= 0 ; i--){
//     reverse += word[i];
// }
// if(word == reverse){
//     console.log("Daxil etdiyiniz soz polindromdur")
// }else{
//     console.log("Daxil etdiyiniz soz polindrom deyil")

// }

//Task 3
// let num = Number(prompt("Bir eded daxil edin:"));
// let arr = [3, 6, 12, 4, 8, 9, 11, 10];
// let count = 0;
// for (let i = 0; i < arr.length; i++) {
//     if (num < arr[i]) {
//         count++;
//     }
// }
// if (count == 0) {
//     console.log("Daxil etdiyiniz eded butun ededlerden boyukdur")
// } else {
//     console.log("Daxil etdiyiniz ededin kicik oldugu eded sayi:")
//     console.log(count);
// }

//Task 4
// let input = Number(prompt("Bir ədəd daxil edin:"));
// let sum = 0;
// for (let i = 1; i < input; i++) {
//     if(input % i == 0){
//         sum = sum + i;
//     }
// }
// if(input < sum){
//     console.log("Aboundant")
// }else{
//     console.log("Deficient")
// }

// Task 5
// function squareArray(nums){
//     let newArray = [];
//     for (let i = 0; i < nums.length; i++) {
//         newArray.push(nums[i]*nums[i])
//     }
//     console.log(newArray)

// }
 
// let nums = [3, 6, 12, 4, 8, 9, 11, 10];
// squareArray(nums);

