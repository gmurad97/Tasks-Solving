function merge(nums1, m, nums2, n) {
    return nums1 = [].concat(
        nums1.filter((v, i) => {
            return i < m;
        }), nums2.filter((v, i) => {
            return i < n;
        })).sort((a, b) => {
            return a - b;
        });
};