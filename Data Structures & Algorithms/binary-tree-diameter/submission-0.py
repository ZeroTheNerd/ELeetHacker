# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def diameterOfBinaryTree(self, root: Optional[TreeNode]) -> int:
        longestHeight = 0
        def dfs(root) -> int:
            nonlocal longestHeight
            if root is None:
                return 0
            leftH = dfs(root.left)
            rightH = dfs(root.right)
            longestHeight = max(longestHeight, leftH + rightH)
            print(longestHeight)
            return 1 + max(leftH, rightH)
        dfs(root)
        return longestHeight

        