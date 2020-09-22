static int migratoryBirds(List<int> arr) 
{
    return arr.GroupBy(_ => _).Select(_ => new{Key = _.Key,Value = _.Count()}).Aggregate((current, next) => current.Value > next.Value ? current : current.Value == next.Value ? current.Key < next.Key ? current : next : next).Key;
}
