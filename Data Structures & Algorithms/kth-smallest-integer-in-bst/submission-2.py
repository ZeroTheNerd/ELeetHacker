# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def kthSmallest(self, root: Optional[TreeNode], k: int) -> int:
        #sortedArray = []
        count = 0
        kthele = 0

        def dfs(root) -> bool:
            nonlocal count
            nonlocal kthele
            if root is None:
                return False


            dfs(root.left)
            count += 1
            if count == k:
                kthele = root.val
                return True
            #sortedArray.append(root.val)
            return dfs(root.right)

        dfs(root)
        return kthele

        