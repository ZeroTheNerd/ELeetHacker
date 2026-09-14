# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def levelOrder(self, root: Optional[TreeNode]) -> List[List[int]]:
        if root is None:
            return []
        result = []
        queue = deque()
        queue.append(root)
        while queue:
            queueLen = len(queue)
            currentLevel = []
            for i in range(queueLen):
                current = queue.popleft()
                if current:
                    currentLevel.append(current.val)
                    if current.left:
                        queue.append(current.left)
                    if current.right:
                        queue.append(current.right)
            result.append(currentLevel)

        return result               


            

