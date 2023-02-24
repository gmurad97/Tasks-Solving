function isPalindrome(s) {
  let regExp = /[^0-9a-zA-Z]/g;
  let tmp = s.replace(regExp, '').replace(/ /g,'').toLowerCase();
  return tmp === tmp.split('').reverse().join('');
}
