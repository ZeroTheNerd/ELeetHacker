class Solution:
    def subsets(self, nums: List[int]) -> List[List[int]]:
        result = []
        currentSub = []
        def dfs(i):
            if i >= len(nums):
                result.append(currentSub.copy())
                return
            #include
            currentSub.append(nums[i])
            dfs(i + 1)

            #exclude
            currentSub.pop()
            dfs(i + 1)

        dfs(0)
        return result

        
        