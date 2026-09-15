class Solution:
    def numIslands(self, grid: List[List[str]]) -> int:
        numOfIslands = 0
        def bfs(row, col):
            queue = deque([(row, col)])
            #visited = set()
            grid[row][col] == "0"
            directions = [(-1, 0), (0, -1), (0, 1), (1, 0)]
            while queue:
                row, col = queue.popleft()
                for row_change, col_change in directions:
                    new_row = row + row_change
                    new_col = col + col_change
                    if(0 <= new_row < len(grid) and 0 <= new_col < len(grid[0]) and grid[new_row][new_col] == "1"):
                        grid[new_row][new_col] = "0"
                        queue.append([new_row, new_col])
                        #visited.append(new_row, new_col)



        
        for i in range(len(grid)):
            for j in range(len(grid[i])):
                if grid[i][j] == "1":
                    numOfIslands += 1
                    bfs(i, j)

        return numOfIslands




        

        