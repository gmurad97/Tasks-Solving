var singleNumber = function(nums) {
    let uniqueNum = 0;
    for(let num of nums){
        uniqueNum ^= num;
    }
    return uniqueNum;
};