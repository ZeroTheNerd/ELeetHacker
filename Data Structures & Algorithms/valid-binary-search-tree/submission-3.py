# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def isValidBST(self, root: Optional[TreeNode]) -> bool:
        
        def dfs(root, lowerbound, upperbound): 
            if root is None:
                return True
            if root.val >= upperbound or root.val <= lowerbound:
                return False
            return (dfs(root.left, lowerbound, root.val) and dfs(root.right, root.val, upperbound))

        
        return dfs(root, float("-inf"), float("inf"))   
