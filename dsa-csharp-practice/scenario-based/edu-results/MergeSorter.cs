using System.Collections.Generic;
public class MergeSorter{
    public static List<Student> MergeSort(List<Student> students){
        if (students.Count <= 1){
            return students;
        }
        int mid = students.Count / 2;
        List<Student> left = students.GetRange(0, mid);
        List<Student> right = students.GetRange(mid, students.Count - mid);
        left = MergeSort(left);
        right = MergeSort(right);
        return Merge(left, right);
    }
    private static List<Student> Merge(List<Student> left, List<Student> right){
        List<Student> result = new List<Student>();
        int i = 0, j = 0;
        while (i < left.Count && j < right.Count){
            // Descendig order (highest marks first)
            if (left[i].Marks >= right[j].Marks){
                result.Add(left[i]);
                i++;
            }else{
                result.Add(right[j]);
                j++;
            }
        }
        result.AddRange(left.GetRange(i, left.Count - i));
        result.AddRange(right.GetRange(j, right.Count - j));
        return result;
    }
}
